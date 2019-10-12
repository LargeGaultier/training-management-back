using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class UeSkillConfiguration : IEntityTypeConfiguration<UeSkill>
    {
        public void Configure(EntityTypeBuilder<UeSkill> entity)
        {
            //entity.HasKey(e => new { e.IdUe, e.IdSkill });

            //entity.Property(e => e.IdUe).HasColumnName("idUe");

            //entity.Property(e => e.IdSkill).HasColumnName("idSkill");

            //entity.HasOne(d => d.Skill)
            //    .WithMany(p => p.UeSkills)
            //    .HasForeignKey(d => d.IdSkill)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_UeSkill_Skill");

            //entity.HasOne(d => d.Ue)
            //    .WithMany(p => p.UeSkills)
            //    .HasForeignKey(d => d.IdUe)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_UeSkill_Ue");
        }
    }
}