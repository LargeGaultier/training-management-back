using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Run;

namespace TrainingManagement.RestApi.Domain
{
    public partial class EvaluationProjectSkillConfiguration : IEntityTypeConfiguration<Run_EvaluationIndividualProjectSkill>
    {
        public void Configure(EntityTypeBuilder<Run_EvaluationIndividualProjectSkill> entity)
        {
                //entity.HasKey(e => new { e.IdEvaluation, e.IdProjectSkill });

                //entity.Property(e => e.IdEvaluation).HasColumnName("idEvaluation");

                //entity.Property(e => e.IdProjectSkill).HasColumnName("idProjectSkill");

                //entity.HasOne(d => d.IdEvaluationNavigation)
                //    .WithMany(p => p.EvaluationProjectSkills)
                //    .HasForeignKey(d => d.IdEvaluation)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_EvaluationProjectSkill_Evaluation");

                //entity.HasOne(d => d.IdLevelReachedNavigation)
                //    .WithMany(p => p.EvaluationProjectSkills)
                //    .HasForeignKey(d => d.IdLevelReached)
                //    .HasConstraintName("FK_EvaluationProjectSkill_Level");

                //entity.HasOne(d => d.IdProjectSkillNavigation)
                //    .WithMany(p => p.EvaluationProjectSkills)
                //    .HasForeignKey(d => d.IdProjectSkill)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_EvaluationProjectSkill_ProjectSkill");
        }
    }
}
