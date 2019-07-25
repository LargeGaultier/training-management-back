using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    public partial class EvaluationConfiguration : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> entity)
        {
            
                entity.HasOne(d => d.EducationalManager)
                    .WithMany(p => p.Evaluations)
                    .HasForeignKey(d => d.EducationalManagerId);

                entity.HasOne(d => d.Intervener)
                    .WithMany(p => p.Evaluations)
                    .HasForeignKey(d => d.IntervenerId);

                entity.HasOne(d => d.ParentEvaluation)
                    .WithMany(p => p.InverseParentEvaluations)
                    .HasForeignKey(d => d.ParentEvaluationId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Evaluations)
                    .HasForeignKey(d => d.StudentId);
         
        }
    }
}
