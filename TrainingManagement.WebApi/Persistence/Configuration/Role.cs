using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    //public partial class RoleConfiguration : IEntityTypeConfiguration<Role>
    //{
    //    public void Configure(EntityTypeBuilder<Role> entity)
    //    {
    //        entity.HasOne(d => d.EducationalManager)
    //                 .WithMany(p => p.Roles)
    //                 .HasForeignKey(d => d.EducationalManagerId);

    //        entity.HasOne(d => d.Intervener)
    //            .WithMany(p => p.Roles)
    //            .HasForeignKey(d => d.IntervenerId);

    //        entity.HasOne(d => d.Student)
    //            .WithMany(p => p.Roles)
    //            .HasForeignKey(d => d.StudentId);
    //    }
    //}
}
