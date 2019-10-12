using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{

    public class Ref_TagTrainingTeamMemberConfiguration : IEntityTypeConfiguration<Ref_TagTrainingTeamMember>
    {
        public void Configure(EntityTypeBuilder<Ref_TagTrainingTeamMember> entity)
        {
            entity.HasOne(d => d.Ref_Tag)
                .WithMany(p => p.Ref_TagTrainingTeamMembers)
                .HasForeignKey(d => d.Ref_TagId);

            entity.HasOne(d => d.Ref_TrainingTeamMember)
                .WithMany(p => p.Ref_TagTrainingTeamMembers)
                .HasForeignKey(d => d.Ref_TagId);
        }
    }
}