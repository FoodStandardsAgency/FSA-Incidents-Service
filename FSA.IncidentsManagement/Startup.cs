using AutoMapper;
using AutoMapper.EquivalencyExpression;
using EntityFrameworkCore.TemporalTables.Extensions;
using FluentValidation.AspNetCore;
using FSA.Attachments;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.ModelValidators;
using FSA.IncidentsManagement.Root.Domain;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.MapperProfile;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.TokenCacheProviders.InMemory;
using Microsoft.OpenApi.Models;
using Sims.Application;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace FSA.IncidentsManagement
{
    public class Startup
    {
        private readonly IWebHostEnvironment env;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            this.env = env;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMicrosoftWebApiAuthentication(Configuration, subscribeToJwtBearerMiddlewareDiagnosticsEvents: true)
                    .AddMicrosoftWebApiCallsWebApi(Configuration)
                    .AddInMemoryTokenCaches();

            services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            {

                // The valid audiences are both the Client ID (options.Audience) and api://{ClientID}
                options.TokenValidationParameters.ValidAudiences = new string[]
                {
                        options.Audience, $"api://{options.Audience}", $"https://{options.Audience}"
                };
            });
            services.AddScoped<UserInfo>();
            // grabbing current userInfo
            services.AddHttpContextAccessor();
            // outside api calls [OBO]
            services.AddHttpClient();

            services.AddMvc(opt =>
            {
                opt.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.CustomOperationIds(apiDesc =>
                {
                    return apiDesc.TryGetMethodInfo(out MethodInfo methodInfo) ? methodInfo.Name : null;
                });

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "fsa incident management", Version = "v1" });
                c.EnableAnnotations();
            });

            services.Configure<IISServerOptions>(options =>
            {
                options.MaxRequestBodySize = int.MaxValue;
            });

            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue; // if don't set default value is: 128 MB
                x.MultipartHeadersLengthLimit = int.MaxValue;
            });

            services.AddScoped<X509Certificate2>((o) => new X509Certificate2(Convert.FromBase64String(Configuration["SharePointAccess"])));


            services.AddAutoMapper((cfg)=> {
                cfg.AddProfile<SimsDbMappingProfile>();
                cfg.AddProfile<WebMappingProfile>();
                cfg.AddCollectionMappers();
            });

            
            var simsConn = Configuration.GetConnectionString("SIMSDbConn");

            services.AddDbContext<SimsDbContext>((provider, opts) => opts
                .UseSqlServer(simsConn, (d) =>
                {
                    d.EnableRetryOnFailure(15);
                    d.CommandTimeout(100);
                })
                .UseInternalServiceProvider(provider));

            services.AddEntityFrameworkSqlServer();
            
            services.RegisterTemporalTablesForDatabase<SimsDbContext>();

            services.AddScoped<ISIMSApplication, SimsManangement>((srv)=> {
                var db = srv.GetRequiredService<SimsDbContext>();
                var map = srv.GetRequiredService<IMapper>();
                var userInfo = srv.GetRequiredService<UserInfo>();
                var attachments = srv.GetRequiredService<ISIMSAttachmentHost>();
                return new SimsManangement(db, map, attachments, userInfo.GetTenantId());
            });

            services.AddScoped<ISIMSAttachmentHost, SimsAttachments>((o) =>
            {
                var user = o.GetRequiredService<UserInfo>();
                var conf = o.GetRequiredService<IConfiguration>();
                var section = conf.GetSection("AzureAd");
                var sharePoint = conf.GetSection("SharePoint");
                var cert = o.GetRequiredService<X509Certificate2>();
                var incidentAttach = new AttachConfig { ContentTypeId = sharePoint["SimsDocCType"], SiteUrl = $"https://{sharePoint["HostSiteCol"]}/{sharePoint["DocSiteUrl"]}" };
                var signalsAttach = new AttachConfig { ContentTypeId = sharePoint["SimsDocCType"], SiteUrl = $"https://{sharePoint["HostSiteCol"]}/{sharePoint["DocSiteUrl"]}" };
                return new SimsAttachments(section["ClientId"], user.GetTenantId(), cert, sharePoint["HostSiteCol"], incidentAttach, signalsAttach);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
#if DEBUG 
            Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
#endif
            app.UseSwagger(opts => opts.SerializeAsV2 = true);
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FSA Incident Management v1");
            });
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwagger();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
