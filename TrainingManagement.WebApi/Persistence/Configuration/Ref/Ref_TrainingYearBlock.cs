using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_TrainingYearBlockConfiguration : IEntityTypeConfiguration<Ref_TrainingYearBlock>
    {
        public void Configure(EntityTypeBuilder<Ref_TrainingYearBlock> entity)
        {
            entity.HasOne(d => d.Ref_TrainingYear)
                .WithMany(p => p.Ref_TrainingYearBlocks)
                .HasForeignKey(d => d.Ref_TrainingYearId);

            entity.HasOne(d => d.Ref_Block)
                .WithMany(p => p.Ref_TrainingYearBlocks)
                .HasForeignKey(d => d.Ref_TrainingYearId);

            entity.HasOne(d => d.Ref_Block)
                .WithMany(p => p.Ref_TrainingYearBlocks)
                .HasForeignKey(d => d.Ref_TrainingYearId);
        }
    }
}