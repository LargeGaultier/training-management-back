using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TrainingManagement.RestApi.Domain;

namespace TrainingManagement.RestApi.Persistence.Configuration
{
    public class DegreeConfiguration : IEntityTypeConfiguration<Degree>
    {
        public void Configure(EntityTypeBuilder<Degree> entity)
        {
            entity.HasOne(d => d.TrainingCenter)
                .WithMany(p => p.Degrees)
                .HasForeignKey(d => d.TrainingCenterId);
        }
    }
}
