using Microsoft.EntityFrameworkCore;
using TrainingManagement.RestApi.Domain;
using TrainingManagement.RestApi.Domain.Ref;
using TrainingManagement.RestApi.Persistence.Extension;

namespace TrainingManagement.RestApi.Persistence
{
    public class TrainingManagementRunDbContext : DbContext
    {

        public TrainingManagementRunDbContext(DbContextOptions<TrainingManagementRefDbContext> options)
           : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
        }


    }
}
