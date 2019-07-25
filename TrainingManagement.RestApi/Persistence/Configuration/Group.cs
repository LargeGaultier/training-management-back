using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace TrainingManagement.RestApi.Domain
{
    public partial class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> entity)
        {
            
                entity.ToTable("Group");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Group_Project");
            
        }
    }
}
