using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_DegreeConfiguration : IEntityTypeConfiguration<Ref_Degree>
    {
        public void Configure(EntityTypeBuilder<Ref_Degree> entity)
        {
            entity.HasOne(d => d.Ref_TrainingCenter)
                .WithMany(p => p.Ref_Degrees)
                .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasMany(d => d.Ref_DegreeBlocks)
                .WithOne(p => p.Ref_Degree)
                .HasForeignKey(d => d.Ref_DegreeId);

            entity.HasMany(d => d.Ref_TrainingYears)
                .WithOne(p => p.Ref_Degree)
                .HasForeignKey(d => d.Ref_DegreeId);
        }
    }
}