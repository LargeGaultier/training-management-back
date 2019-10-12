using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_SkillConfiguration : IEntityTypeConfiguration<Ref_Skill>
    {
        public void Configure(EntityTypeBuilder<Ref_Skill> entity)
        {

        }
    }
}