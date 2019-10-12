using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_UeSkillConfiguration : IEntityTypeConfiguration<Ref_UeSkill>
    {
        public void Configure(EntityTypeBuilder<Ref_UeSkill> entity)
        {
            entity.HasOne(d => d.Ref_Ue)
                .WithMany(p => p.Ref_UeSkills)
                .HasForeignKey(d => d.Ref_UeId);

            entity.HasOne(d => d.Ref_Skill)
                .WithMany(p => p.Ref_UeSkills)
                .HasForeignKey(d => d.Ref_SkillId);
        }
    }
}