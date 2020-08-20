using EntityFrameworkCore.TemporalTables.Extensions;
using FluentValidation.AspNetCore;
using FSA.Attachments;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.ModelValidators;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Repositories;
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
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Net.Http;
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

            services.AddHttpClient();

            //services.AddScoped<IFSATermStore, AttachmentTerms>((o) =>
            //{
            //    var conf = o.GetRequiredService<IConfiguration>();
            //    var azureAd = conf.GetSection("AzureAd");
            //    var sharepointSec = conf.GetSection("SharePoint");
            //    var user = o.GetRequiredService<UserInfo>();
            //  return  new AttachmentTerms(o.GetRequiredService<IHttpClientFactory>().CreateClient("taxonomy"), sharepointSec["SimsTermSetId"]); sharepointSec["TagsTermSetId"]);
            //});

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
                //c.DocumentFilter<YamlDocumentFilter>();
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


            var fsaConn = Configuration.GetConnectionString("FSADbConn");
            services.AddDbContext<FSADbContext>((provider, opts) => opts
                        //.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()))
                        .UseSqlServer(fsaConn, (d) =>
                        {
                            d.EnableRetryOnFailure(15);
                            d.CommandTimeout(100);
                        })
                        .UseInternalServiceProvider(provider));

            services.AddEntityFrameworkSqlServer();

            services.RegisterTemporalTablesForDatabase<FSADbContext>();

            services.AddScoped<ILookupDataHost, LookupDataHost>();

            services.AddScoped<ISIMSManager, SIMSDataManager>(ids => new SIMSDataManager(ids.GetRequiredService<FSADbContext>(), ids.GetRequiredService<UserInfo>().GetUserId()));

            services.AddScoped<IFSAAttachments, SPIncidentAttachments>((o) =>
            {
                var user = o.GetRequiredService<UserInfo>();
                var conf = o.GetRequiredService<IConfiguration>();
                var section = conf.GetSection("AzureAd");
                var sharePoint = conf.GetSection("SharePoint");
                var cert = o.GetRequiredService<X509Certificate2>();
                return new SPIncidentAttachments(section["ClientId"], user.GetTenantId(), cert, sharePoint["HostSiteCol"], $"https://{sharePoint["HostSiteCol"]}/{sharePoint["DocSiteUrl"]}", sharePoint["SimsDocCType"]);// Guid.Parse(sharePoint["SimsTermSetId"]));
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
