using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_TagSkillConfiguration : IEntityTypeConfiguration<Ref_TagSkill>
    {
        public void Configure(EntityTypeBuilder<Ref_TagSkill> entity)
        {

        }
    }
}