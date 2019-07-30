using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class SkillRatingLevelConfiguration : IEntityTypeConfiguration<SkillRatingLevel>
    {
        public void Configure(EntityTypeBuilder<SkillRatingLevel> entity)
        {
                //entity.Property(e => e.Description).IsRequired();

                //entity.HasOne(d => d.Skill)
                //    .WithMany(p => p.Levels)
                //    .HasForeignKey(d => d.IdSkill)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("FK_Goal_Skill");
        }
    }
}
