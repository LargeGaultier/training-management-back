using Microsoft.EntityFrameworkCore;
using TrainingManagement.RestApi.Domain;
using TrainingManagement.RestApi.Domain.Ref;
using TrainingManagement.RestApi.Persistence.Extension;

namespace TrainingManagement.RestApi.Persistence
{
    public class TrainingManagementRefDbContext : DbContext
    {

        public TrainingManagementRefDbContext(DbContextOptions<TrainingManagementRefDbContext> options)
           : base(options)
        { }

        public virtual DbSet<TrainingCenter> TrainingCenter { get; set; }
        public virtual DbSet<Uv> Uv { get; set; }
        public virtual DbSet<Ue> Ue { get; set; }
        public virtual DbSet<UeSkill> UeSkill { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
        }


    }
}
