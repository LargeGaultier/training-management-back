using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Run;

namespace TrainingManagement.RestApi.Domain
{
    public partial class EvaluationConfiguration : IEntityTypeConfiguration<Run_EvaluationIndividual>
    {
        public void Configure(EntityTypeBuilder<Run_EvaluationIndividual> entity)
        {
            
                //entity.HasOne(d => d.EducationalManager)
                //    .WithMany(p => p.Evaluations)
                //    .HasForeignKey(d => d.EducationalManagerId);

                //entity.HasOne(d => d.Intervener)
                //    .WithMany(p => p.Evaluations)
                //    .HasForeignKey(d => d.IntervenerId);

                
                //entity.HasOne(d => d.Student)
                //    .WithMany(p => p.Evaluations)
                //    .HasForeignKey(d => d.StudentId);
         
        }
    }
}
