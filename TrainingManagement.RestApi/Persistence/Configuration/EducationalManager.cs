using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
   
    public class EducationalManagerConfiguration : IEntityTypeConfiguration<EducationalManager>
    {
        public void Configure(EntityTypeBuilder<EducationalManager> entity)
        {

        }
    }
}
