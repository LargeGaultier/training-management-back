using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_ProjectSkillConfiguration : IEntityTypeConfiguration<Ref_ProjectSkill>
    {
        public void Configure(EntityTypeBuilder<Ref_ProjectSkill> entity)
        {

        }
    }
}