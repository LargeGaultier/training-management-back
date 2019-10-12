using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> entity)
        {
            //    entity.HasOne(d => d.Intervener)
            //        .WithMany(p => p.Projects)
            //        .HasForeignKey(d => d.IntervenerId);

            //entity.HasOne(d => d.TrainingCenter)
            //.WithMany(p => p.Projects)
            //.HasForeignKey(d => d.TrainingCenterId);
           
        }
    }
}
