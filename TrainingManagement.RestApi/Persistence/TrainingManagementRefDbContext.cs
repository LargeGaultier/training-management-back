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

        public virtual DbSet<Ref_TrainingCenter> Ref_TrainingCenter { get; set; }
        public virtual DbSet<Ref_Uv> Ref_Uv { get; set; }
        public virtual DbSet<Ref_Ue> Ref_Ue { get; set; }
        public virtual DbSet<Ref_UeSkill> Ref_UeSkill { get; set; }
        public virtual DbSet<Ref_Skill> Ref_Skill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
        }


    }
}
