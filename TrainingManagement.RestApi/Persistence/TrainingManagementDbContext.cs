using Microsoft.EntityFrameworkCore;
using TrainingManagement.RestApi.Domain;
using TrainingManagement.RestApi.Persistence.Extension;

namespace TrainingManagement.RestApi.Persistence
{
    public class TrainingManagementDbContext : DbContext
    {

        public TrainingManagementDbContext(DbContextOptions<TrainingManagementDbContext> options)
           : base(options)
        { }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<EducationalManager> EducationalManager { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<EvaluationProjectSkill> EvaluationProjectSkill { get; set; }
        public virtual DbSet<Group> Group1 { get; set; }
        public virtual DbSet<Intervener> Intervener { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectSkill> ProjectSkill { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentGroup> StudentGroup { get; set; }
        public virtual DbSet<Ue> Ue { get; set; }
        public virtual DbSet<UeSkill> UeSkill { get; set; }
        public virtual DbSet<Uv> Uv { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
            modelBuilder.ApplyAllConfigurations();
        }


    }
}
