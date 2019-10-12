using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_TagConfiguration : IEntityTypeConfiguration<Ref_Tag>
    {
        public void Configure(EntityTypeBuilder<Ref_Tag> entity)
        {

        }
    }
}