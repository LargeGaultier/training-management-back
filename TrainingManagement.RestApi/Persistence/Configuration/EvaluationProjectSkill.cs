using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    public partial class EvaluationProjectSkillConfiguration : IEntityTypeConfiguration<EvaluationProjectSkill>
    {
        public void Configure(EntityTypeBuilder<EvaluationProjectSkill> entity)
        {
                entity.HasKey(e => new { e.IdEvaluation, e.IdProjectSkill });

                entity.Property(e => e.IdEvaluation).HasColumnName("idEvaluation");

                entity.Property(e => e.IdProjectSkill).HasColumnName("idProjectSkill");

                entity.HasOne(d => d.IdEvaluationNavigation)
                    .WithMany(p => p.EvaluationProjectSkills)
                    .HasForeignKey(d => d.IdEvaluation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationProjectSkill_Evaluation");

                entity.HasOne(d => d.IdLevelReachedNavigation)
                    .WithMany(p => p.EvaluationProjectSkills)
                    .HasForeignKey(d => d.IdLevelReached)
                    .HasConstraintName("FK_EvaluationProjectSkill_Level");

                entity.HasOne(d => d.IdProjectSkillNavigation)
                    .WithMany(p => p.EvaluationProjectSkills)
                    .HasForeignKey(d => d.IdProjectSkill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationProjectSkill_ProjectSkill");
        }
    }
}
