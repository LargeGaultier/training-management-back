using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_ProjectConfiguration : IEntityTypeConfiguration<Ref_Project>
    {
        public void Configure(EntityTypeBuilder<Ref_Project> entity)
        {
            entity.HasOne(d => d.Ref_TrainingCenter)
                .WithMany(p => p.Ref_Projects)
                .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasOne(d => d.Ref_TrainingTeamMember)
                .WithMany(p => p.Ref_Projects)
                .HasForeignKey(d => d.Ref_TrainingTeamMemberId);

            entity.HasMany(d => d.Ref_ProjectSkills)
                .WithOne(p => p.Ref_Project)
                .HasForeignKey(d => d.Ref_ProjectId);

            entity.HasMany(d => d.Ref_ProjectTrainingTeamMembers)
                .WithOne(p => p.Ref_Project)
                .HasForeignKey(d => d.Ref_ProjectId);
            
        }
    }
}