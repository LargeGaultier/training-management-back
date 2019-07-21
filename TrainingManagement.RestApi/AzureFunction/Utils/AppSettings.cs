using Microsoft.OpenApi;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.AzureFunction.Utils
{
    public class AppSettings : Aliencube.AzureFunctions.Extensions.Configuration.AppSettings.AppSettingsBase
    {
        public AppSettings() : base()
        {
            CurrentOpenApiInfo = new OpenApiInfo();
            CurrentOpenApiInfo.Version = Environment.GetEnvironmentVariable("ApiVersion");
            CurrentOpenApiInfo.Title = Environment.GetEnvironmentVariable("ApiTitle");
            CurrentOpenApiInfo.Description = Environment.GetEnvironmentVariable("ApiDescription");
            CurrentOpenApiInfo.Extensions = null;
            CurrentOpenApiInfo.License = new OpenApiLicense()
            {
                Extensions = null,
                Name = Environment.GetEnvironmentVariable("ApiLicense"),
                Url = new Uri(Environment.GetEnvironmentVariable("ApiLicenseUrl"))
            };

            SwaggerAuthKey = Environment.GetEnvironmentVariable("SwaggerAuthKey");

        }

        public OpenApiInfo CurrentOpenApiInfo { get; set; }
        public string RoutePrefix { get; set; }
        public string SwaggerAuthKey { get; set; }

    }

}


