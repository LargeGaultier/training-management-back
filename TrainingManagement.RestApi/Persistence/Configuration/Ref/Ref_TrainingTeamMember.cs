using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_TrainingTeamMemberConfiguration : IEntityTypeConfiguration<Ref_TrainingTeamMember>
    {
        public void Configure(EntityTypeBuilder<Ref_TrainingTeamMember> entity)
        {
            entity.HasOne(d => d.Ref_TrainingCenter)
                .WithMany(p => p.Ref_TrainingTeamMembers)
                .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasMany(d => d.Ref_ProjectTrainingTeamMembers)
                .WithOne(p => p.Ref_TrainingTeamMember)
                .HasForeignKey(d => d.Ref_TrainingTeamMemberId);

            entity.HasMany(d => d.Ref_Projects)
                .WithOne(p => p.Ref_TrainingTeamMember)
                .HasForeignKey(d => d.Ref_TrainingTeamMemberId);

            entity.HasMany(d => d.Ref_TagTrainingTeamMembers)
                .WithOne(p => p.Ref_TrainingTeamMember)
                .HasForeignKey(d => d.Ref_TrainingTeamMemberId);
        }
    }
}