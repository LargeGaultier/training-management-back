using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TrainingManagement.RestApi.Persistence;

[assembly: FunctionsStartup(typeof(TrainingManagement.RestApi.Startup))]
namespace TrainingManagement.RestApi
{
   
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string SqlConnection = Environment.GetEnvironmentVariable("SqlConnectionString");
            builder.Services.AddDbContext<TrainingManagementDbContext>(
                options => options.UseSqlServer(SqlConnection));
        }
    }
}
