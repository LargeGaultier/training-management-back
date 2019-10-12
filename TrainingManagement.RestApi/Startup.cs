using MediatR;
using MediatR.Pipeline;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Reflection;
using TrainingManagement.RestApi.Application.Infrasctuture;
using TrainingManagement.RestApi.Application.Ref.TrainingCenter.Queries;
using TrainingManagement.RestApi.Persistence;

[assembly: FunctionsStartup(typeof(TrainingManagement.RestApi.Startup))]
namespace TrainingManagement.RestApi
{
   
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string SqlConnection = Environment.GetEnvironmentVariable("SqlConnectionString");
            builder.Services.AddDbContext<TrainingManagementRefDbContext>(
                options => options.UseSqlServer(SqlConnection));

           builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
           builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
           builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
           
            //rajouter la ligne pour le faire par reflexion
           builder.Services.AddMediatR(typeof(GetAllTrainingCenterHandler).GetTypeInfo().Assembly);

            builder.Services.AddMvcCore().AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        }
    }
}
