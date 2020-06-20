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

namespace FSA.IncidentsManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddProtectedWebApi(Configuration, subscribeToJwtBearerMiddlewareDiagnosticsEvents: true);
            //services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            //        {
            //            // This is an Microsoft identity platform Web API
            //            //options.Authority += "/v2.0";

            //            // The valid audiences are both the Client ID (options.Audience) and api://{ClientID}
            //            options.TokenValidationParameters.ValidAudiences = new string[]
            //            {
            //            options.Audience, $"api://{options.Audience}", $"https://{options.Audience}"
            //            };
            //            // D-d-d-delegate
            //            options.TokenValidationParameters.IssuerValidator = Microsoft.IdentityModel.Tokens.Validators.ValidateIssuer;
            //        });

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
            });

            var fsaConn = Configuration.GetConnectionString("FSADbConn");
            services.AddDbContext<FSADbContext>((opts) => opts
                        .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()))
                        .UseSqlServer(fsaConn, (d) =>{
                                d.EnableRetryOnFailure(15);
                                d.CommandTimeout(100);
                            }));

            services.AddScoped<UserInfo>();
            services.AddScoped<ILookupDataHost, LookupDataHost>();
            services.AddScoped<IFSAIncidentsData, FSAIncidentsManagement>(ids => new FSAIncidentsManagement(ids.GetRequiredService<FSADbContext>(), ids.GetRequiredService<UserInfo>().GetUserId()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
            app.UseSwagger(opts=>opts.SerializeAsV2=true);
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
