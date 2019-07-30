using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace TrainingManagement.RestApi.Persistence
{
    public class TrainingManagementDbContextFactory : IDesignTimeDbContextFactory<TrainingManagementRefDbContext>
    {
        public TrainingManagementRefDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrainingManagementRefDbContext>();
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("SqlConnectionString"));

            return new TrainingManagementRefDbContext(optionsBuilder.Options);
        }
    }
}
