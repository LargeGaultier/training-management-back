using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_UeConfiguration : IEntityTypeConfiguration<Ref_Ue>
    {
        public void Configure(EntityTypeBuilder<Ref_Ue> entity)
        {
            entity.HasOne(d => d.Ref_Uv)
                .WithMany(p => p.Ref_Ues)
                .HasForeignKey(d => d.Ref_UvId);

            entity.HasMany(d => d.Ref_UeSkills)
                .WithOne(p => p.Ref_Ue)
                .HasForeignKey(d => d.Ref_UeId);
        }
    }
}