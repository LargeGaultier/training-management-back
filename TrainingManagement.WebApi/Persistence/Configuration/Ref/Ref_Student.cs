using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_StudentConfiguration : IEntityTypeConfiguration<Ref_Student>
    {
        public void Configure(EntityTypeBuilder<Ref_Student> entity)
        {

        }
    }
}