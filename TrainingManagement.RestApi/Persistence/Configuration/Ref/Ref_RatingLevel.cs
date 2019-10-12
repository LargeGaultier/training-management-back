using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_RatingLevelConfiguration : IEntityTypeConfiguration<Ref_RatingLevel>
    {
        public void Configure(EntityTypeBuilder<Ref_RatingLevel> entity)
        {

        }
    }
}