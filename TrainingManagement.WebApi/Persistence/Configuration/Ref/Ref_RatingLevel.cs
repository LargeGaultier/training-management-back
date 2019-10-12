using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_RatingLevelConfiguration : IEntityTypeConfiguration<Ref_RatingLevel>
    {
        public void Configure(EntityTypeBuilder<Ref_RatingLevel> entity)
        {

        }
    }
}