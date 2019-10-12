using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_ProjectTrainingTeamMemberConfiguration : IEntityTypeConfiguration<Ref_ProjectTrainingTeamMember>
    {
        public void Configure(EntityTypeBuilder<Ref_ProjectTrainingTeamMember> entity)
        {
            entity.HasOne(d => d.Ref_TrainingTeamMember)
                .WithMany(p => p.Ref_ProjectTrainingTeamMembers)
                .HasForeignKey(d => d.Ref_TrainingTeamMemberId);

            entity.HasOne(d => d.Ref_Project)
                .WithMany(p => p.Ref_ProjectTrainingTeamMembers)
                .HasForeignKey(d => d.Ref_ProjectId);
        }
    }
}