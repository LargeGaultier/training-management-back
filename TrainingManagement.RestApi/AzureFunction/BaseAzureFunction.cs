using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.AzureFunction
{
    public abstract class BaseAzureFunction
    {
        public string Version { get; set; }


        protected IMediator Mediator;


        public BaseAzureFunction(IMediator mediator)
        {
            Version = Environment.GetEnvironmentVariable("ApiVersion");
            Mediator = mediator;
        }
    }
}
