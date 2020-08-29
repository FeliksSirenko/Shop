using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Shop.Infrastructure.ApiConfigurations;

namespace Shop.Api.ServiceConfigurations
{
    /// <summary>
    /// Extensions methods to register swagger to a solution.
    /// </summary>
    public static class SwaggerExtension
    {
        /// <summary>
        /// Registers and configures swagger from appsettings.json configuration file.
        /// </summary>
        /// <param name="services">Collection of services.</param>
        /// <param name="config">Settings to be configured in Swagger.</param>
        public static void AddSwagger(this IServiceCollection services, IConfiguration config)
        {
            var swaggerConfig = ReadSwaggerSettingsFromConfiguration(config);

            services.AddSwaggerGen(docs =>
            {
                docs.SwaggerDoc(swaggerConfig.ApiVersion, new OpenApiInfo
                {
                    Title = swaggerConfig.ApiTitle,
                    Version = swaggerConfig.ApiVersion,
                    Description = swaggerConfig.Description,
                    Contact = new OpenApiContact
                    {
                        Name = swaggerConfig.Contact.Name,
                        Email = swaggerConfig.Contact.Email
                    },
                    License = new OpenApiLicense
                    {
                        Name = swaggerConfig.License.Name,
                        Url = new Uri(swaggerConfig.License.Url)
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                docs.IncludeXmlComments(xmlPath);
            });
        }

        /// <summary>
        /// Configures Swagger for usage by the application.
        /// </summary>
        /// <param name="app">Application builder.</param>
        /// <param name="config">Configuration of an application.</param>
        public static void UseSwagger(this IApplicationBuilder app, IConfiguration config)
        {
            var swaggerConfig = ReadSwaggerSettingsFromConfiguration(config);

            app.UseSwagger();

            app.UseSwaggerUI(action =>
            {
                action.SwaggerEndpoint(swaggerConfig.EndpointUrl, $"{swaggerConfig.ApiTitle} {swaggerConfig.ApiVersion}");
            });
        }

        private static SwaggerConfig ReadSwaggerSettingsFromConfiguration(IConfiguration config)
        {
            var swagger = new SwaggerConfig();
            config.GetSection("Swagger").Bind(swagger);
            return swagger;
        }
    }
}
