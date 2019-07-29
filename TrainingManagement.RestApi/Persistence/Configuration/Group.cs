using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;
using TrainingManagement.RestApi.Domain.Run;

namespace TrainingManagement.RestApi.Domain
{
    public partial class GroupConfiguration : IEntityTypeConfiguration<Run_ProjetGroup>
    {
        public void Configure(EntityTypeBuilder<Run_ProjetGroup> entity)
        {
            
                entity.ToTable("Group");

                //entity.HasOne(d => d.Project)
                //    .WithMany(p => p.Groups)
                //    .HasForeignKey(d => d.ProjectId)
                //    .HasConstraintName("FK_Group_Project");
            
        }
    }
}
