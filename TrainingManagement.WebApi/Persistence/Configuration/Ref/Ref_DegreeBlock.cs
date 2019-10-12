using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_DegreeBlockConfiguration : IEntityTypeConfiguration<Ref_DegreeBlock>
    {
        public void Configure(EntityTypeBuilder<Ref_DegreeBlock> entity)
        {
            entity.HasOne(d => d.Ref_Degree)
                .WithMany(p => p.Ref_DegreeBlocks)
                .HasForeignKey(d => d.Ref_DegreeId);

            entity.HasOne(d => d.Ref_Block)
                .WithMany(p => p.Ref_DegreeBlocks)
                .HasForeignKey(d => d.Ref_BlockId);
        }
    }
}