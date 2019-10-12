using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace TrainingManagement.RestApi.Persistence
{
    public class TrainingManagementRefDbContextFactory : IDesignTimeDbContextFactory<TrainingManagementRefDbContext>
    {
        public TrainingManagementRefDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrainingManagementRefDbContext>();
            string connexionString = "Server = trainingmanagementsqlserver.Database.windows.net; Database = TrainingManagement; User Id = trainingadmin;Password = DevDb2019!;";


            //string connexionString = "tcp:trainingmanagementsqlserver.Database.windows.net:1433;Initial Catalog=TrainingManagement;Persist Security Info=False;User ID=trainingadmin;Password=DevDb2019!;MultipleActiveResultsSets=False;Encrypt=True;ConnectionTimeout=30;";
            optionsBuilder.UseSqlServer(connexionString);

            return new TrainingManagementRefDbContext(optionsBuilder.Options);
        }
    }
}
