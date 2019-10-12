using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_TagConfiguration : IEntityTypeConfiguration<Ref_Tag>
    {
        public void Configure(EntityTypeBuilder<Ref_Tag> entity)
        {

        }
    }
}