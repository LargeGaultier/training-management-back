using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_BlockConfiguration : IEntityTypeConfiguration<Ref_Block>
    {
        public void Configure(EntityTypeBuilder<Ref_Block> entity)
        {
            entity.HasOne(d => d.Ref_TrainingCenter)
                .WithMany(p => p.Ref_Blocks)
                .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasMany(d => d.Ref_DegreeBlocks)
                .WithOne(p => p.Ref_Block)
                .HasForeignKey(d => d.Ref_BlockId);

            entity.HasMany(d => d.Ref_TrainingYearBlocks)
                .WithOne(p => p.Ref_Block)
                .HasForeignKey(d => d.Ref_BlockId);

            entity.HasMany(d => d.Ref_Uvs)
                .WithOne(p => p.Ref_Block)
                .HasForeignKey(d => d.Ref_BlockId);
        }
    }
}
