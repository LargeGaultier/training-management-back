using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_StudentConfiguration : IEntityTypeConfiguration<Ref_Student>
    {
        public void Configure(EntityTypeBuilder<Ref_Student> entity)
        {

        }
    }
}