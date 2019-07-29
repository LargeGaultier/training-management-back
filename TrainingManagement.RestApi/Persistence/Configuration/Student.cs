using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            //entity.HasOne(d => d.Class)
            //     .WithMany(p => p.Students)
            //     .HasForeignKey(d => d.ClassId)
            //     .OnDelete(DeleteBehavior.ClientSetNull);

            //entity.HasOne(d => d.TrainingCenter)
            //    .WithMany(p => p.Students)
            //    .HasForeignKey(d => d.TrainingCenterId)
            //    .OnDelete(DeleteBehavior.ClientSetNull);


        }
    }
}
