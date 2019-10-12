using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_SkillRatingLevelConfiguration : IEntityTypeConfiguration<Ref_SkillRatingLevel>
    {
        public void Configure(EntityTypeBuilder<Ref_SkillRatingLevel> entity)
        {

        }
    }
}