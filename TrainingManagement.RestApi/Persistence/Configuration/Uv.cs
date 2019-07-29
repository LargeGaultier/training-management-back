using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class UvConfiguration : IEntityTypeConfiguration<Uv>
    {
        public void Configure(EntityTypeBuilder<Uv> entity)
        {
            entity.HasOne(d => d.TrainingCenter)
                .WithMany(p => p.Uvs)
                .HasForeignKey(d => d.TrainingCenterId);
        }
    }
}
