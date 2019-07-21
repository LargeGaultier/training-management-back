using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.AzureFunction
{
    public abstract class BaseAzureFunction
    {
        public string Version { get; set; }



        public BaseAzureFunction()
        {
            Version = Environment.GetEnvironmentVariable("ApiVersion");
        }
    }
}
