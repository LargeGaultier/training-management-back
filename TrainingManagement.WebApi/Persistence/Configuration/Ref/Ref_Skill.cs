using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_SkillConfiguration : IEntityTypeConfiguration<Ref_Skill>
    {
        public void Configure(EntityTypeBuilder<Ref_Skill> entity)
        {

        }
    }
}