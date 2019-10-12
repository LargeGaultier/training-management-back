using Microsoft.EntityFrameworkCore;
using TrainingManagement.WebApi.Domain;
using TrainingManagement.WebApi.Domain.Ref;
using TrainingManagement.WebApi.Persistence.Extension;

namespace TrainingManagement.WebApi.Persistence
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
