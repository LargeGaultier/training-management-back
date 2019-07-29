using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Run;

namespace TrainingManagement.RestApi.Domain
{
   
    public class EducationalManagerConfiguration : IEntityTypeConfiguration<Run_EducationalManager>
    {
        public void Configure(EntityTypeBuilder<Run_EducationalManager> entity)
        {

        }
    }
}
