using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    public partial class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> entity)
        {
            entity.HasOne(d => d.Domain)
                  .WithMany(p => p.Skills)
                  .HasForeignKey(d => d.DomainId);

            entity.HasOne(d => d.TrainingCenter)
                .WithMany(p => p.Skills)
                .HasForeignKey(d => d.TrainingCenterId);
        }
    }
}
