using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_ProjectSkillConfiguration : IEntityTypeConfiguration<Ref_ProjectSkill>
    {
        public void Configure(EntityTypeBuilder<Ref_ProjectSkill> entity)
        {

        }
    }
}