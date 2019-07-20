using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace TrainingManagement.RestApi.Persistence
{
    public class TrainingManagementDbContextFactory : IDesignTimeDbContextFactory<TrainingManagementDbContext>
    {
        public TrainingManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrainingManagementDbContext>();
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("SqlConnectionString"));

            return new TrainingManagementDbContext(optionsBuilder.Options);
        }
    }
}
