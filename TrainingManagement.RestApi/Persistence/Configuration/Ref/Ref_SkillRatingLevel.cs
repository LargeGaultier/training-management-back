using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_SkillRatingLevelConfiguration : IEntityTypeConfiguration<Ref_SkillRatingLevel>
    {
        public void Configure(EntityTypeBuilder<Ref_SkillRatingLevel> entity)
        {

        }
    }
}