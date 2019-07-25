using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    public partial class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> entity)
        {
                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.IdSkillNavigation)
                    .WithMany(p => p.Levels)
                    .HasForeignKey(d => d.IdSkill)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Goal_Skill");
        }
    }
}
