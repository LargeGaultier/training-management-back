using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_TagSkillConfiguration : IEntityTypeConfiguration<Ref_TagSkill>
    {
        public void Configure(EntityTypeBuilder<Ref_TagSkill> entity)
        {

        }
    }
}