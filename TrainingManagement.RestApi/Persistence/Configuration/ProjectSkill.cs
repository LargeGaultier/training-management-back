using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    public partial class ProjectSkillConfiguration : IEntityTypeConfiguration<ProjectSkill>
    {
        public void Configure(EntityTypeBuilder<ProjectSkill> entity)
        {
            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Project)
                .WithMany(p => p.ProjectSkills)
                .HasForeignKey(d => d.ProjectId);

            entity.HasOne(d => d.RequiredLevel)
                .WithMany(p => p.ProjectSkills)
                .HasForeignKey(d => d.RequiredLevelId)
                .HasConstraintName("FK_ProjectSkill_Level1");

            entity.HasOne(d => d.Skill)
                .WithMany(p => p.ProjectSkills)
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
