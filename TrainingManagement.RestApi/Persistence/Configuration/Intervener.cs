using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class IntervenerConfiguration : IEntityTypeConfiguration<TrainingTeamMember>
    {
        public void Configure(EntityTypeBuilder<TrainingTeamMember> entity)
        {
            entity.HasOne(d => d.TrainingCenter)
                .WithMany(p => p.Interveners)
                .HasForeignKey(d=> d.TrainingCenterId);
        }
    }
}
