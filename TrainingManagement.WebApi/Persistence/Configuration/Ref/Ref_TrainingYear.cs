using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_TrainingYearConfiguration : IEntityTypeConfiguration<Ref_TrainingYear>
    {
        public void Configure(EntityTypeBuilder<Ref_TrainingYear> entity)
        {
            entity.HasOne(d => d.Ref_Degree)
                .WithMany(p => p.Ref_TrainingYears)
                .HasForeignKey(d => d.Ref_DegreeId);

            entity.HasMany(d => d.Ref_TrainingYearBlocks)
                .WithOne(p => p.Ref_TrainingYear)
                .HasForeignKey(d => d.Ref_TrainingYearId);
        }
    }
}