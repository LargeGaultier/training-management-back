using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_UvConfiguration : IEntityTypeConfiguration<Ref_Uv>
    {
        public void Configure(EntityTypeBuilder<Ref_Uv> entity)
        {

            entity.HasOne(d => d.Ref_Block)
                .WithMany(p => p.Ref_Uvs)
                .HasForeignKey(d => d.Ref_BlockId);

            entity.HasMany(d => d.Ref_Uvs)
                .WithOne(p => p.Ref_UvParent)
                .HasForeignKey(d => d.Ref_UvParentId);

            entity.HasMany(d => d.Ref_Ues)
                .WithOne(p => p.Ref_Uv)
                .HasForeignKey(d => d.Ref_UvId);

            entity.HasMany(d => d.Ref_TrainingYearBlocks)
                .WithOne(p => p.Ref_Uv)
                .HasForeignKey(d => d.Ref_UvId);
        }
    }
}