using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> entity)
        {
            //entity.HasMany(d => d.TagSkills)
            //      .WithOne(p => p.Skill)
            //      .HasForeignKey(d => d.SkillId);

            //entity.HasOne(d => d.TrainingCenter)
            //    .WithMany(p => p.Skills)
            //    .HasForeignKey(d => d.TrainingCenterId);
        }
    }
}
