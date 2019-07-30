using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Persistence.Configuration
{
    public class DegreeUvConfiguration : IEntityTypeConfiguration<DegreeUv>
    {
        public void Configure(EntityTypeBuilder<DegreeUv> entity)
        {
            //entity.HasOne(d => d.Degree)
            //    .WithMany(p => p.DegreeUvs)
            //    .HasForeignKey(d => d.DegreeId);

            //entity.HasOne(d => d.Uv)
            //    .WithMany(p => p.DegreeUvs)
            //    .HasForeignKey(d => d.UvId);
        }
    }
}
