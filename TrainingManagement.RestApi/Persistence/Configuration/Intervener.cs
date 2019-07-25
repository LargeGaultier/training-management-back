using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    public partial class IntervenerConfiguration : IEntityTypeConfiguration<Intervener>
    {
        public void Configure(EntityTypeBuilder<Intervener> entity)
        {
            entity.HasOne(d => d.TrainingCenter)
                .WithMany(p => p.Interveners)
                .HasForeignKey(d=> d.TrainingCenterId);
        }
    }
}
