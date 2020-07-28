using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using FSA.IncidentsManagementDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagementDb.Repositories;
using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using FSA.IncidentsManagement.ModelValidators;
using FluentValidation.AspNetCore;
using FSA.IncidentsManagement.Misc;
using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.Attachments;
using Microsoft.Graph;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Hosting.Internal;

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
            
               services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftWebApi(Configuration, subscribeToJwtBearerMiddlewareDiagnosticsEvents: true);

            services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                // This is an Microsoft identity platform Web API
                //options.Authority += "/v2.0";

                // The valid audiences are both the Client ID (options.Audience) and api://{ClientID}
                options.TokenValidationParameters.ValidAudiences = new string[]
                {
                        options.Audience, $"api://{options.Audience}", $"https://{options.Audience}"
                };
            });

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

            

            services.AddScoped<X509Certificate2>((o)=> new X509Certificate2(System.IO.Path.Combine(Environment.CurrentDirectory, "SharepointAccess.pfx")));
           

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



            services.AddScoped<UserInfo>();
            services.AddScoped<ILookupDataHost, LookupDataHost>();


            services.AddScoped<ISIMSManager, SIMSDataManager>(ids => new SIMSDataManager(ids.GetRequiredService<FSADbContext>(), ids.GetRequiredService<UserInfo>().GetUserId()));

            services.AddScoped<IFSAAttachments, SPIncidentAttachments>((o) => {
                var user = o.GetRequiredService<UserInfo>();
                var conf = o.GetRequiredService<IConfiguration>();
                var section = conf.GetSection("AzureAd");
                var cert = o.GetRequiredService<X509Certificate2>();


                return new SPIncidentAttachments(section["ClientId"], user.GetTenantId(), cert, "65F37FA2302BCD278886172AA2220249A0FF92D0", $"https://{conf["HostSiteCol"]}/{conf["DocSiteUrl"]}", conf["IncidentDocCType"]);
                //return new GrIncidentAttachments(section["ClientId"], section["GraphClientSecret"], user.GetTenantId(), conf["HostSiteCol"], conf["DocSiteUrl"], conf["IncidentDocCType"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
            app.UseSwagger(opts => opts.SerializeAsV2 = true);
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FSA Incident Management v1");
            });

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
