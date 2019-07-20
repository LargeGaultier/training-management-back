using Microsoft.EntityFrameworkCore;
using TrainingManagement.RestApi.Domain;

namespace TrainingManagement.RestApi.Persistence
{
    public class TrainingManagementDbContext : DbContext
    {

        public TrainingManagementDbContext(DbContextOptions<TrainingManagementDbContext> options)
           : base(options)
        { }


        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolClass> SchoolClasses {get;set;}


    }
}
