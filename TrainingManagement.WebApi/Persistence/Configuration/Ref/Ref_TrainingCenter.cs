using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain
{

    public class Ref_TrainingCenterConfiguration : IEntityTypeConfiguration<Ref_TrainingCenter>
    {
        public void Configure(EntityTypeBuilder<Ref_TrainingCenter> entity)
        {
            entity.HasMany(d => d.Ref_Students)
                .WithOne(p => p.Ref_TrainingCenter)
                .HasForeignKey(d => d.Ref_TrainingCenterId); 

            entity.HasMany(d => d.Ref_TrainingTeamMembers)
                 .WithOne(p => p.Ref_TrainingCenter)
                 .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasMany(d => d.Ref_Degrees)
                 .WithOne(p => p.Ref_TrainingCenter)
                 .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasMany(d => d.Ref_Skills)
                 .WithOne(p => p.Ref_TrainingCenter)
                 .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasMany(d => d.Ref_Blocks)
                 .WithOne(p => p.Ref_TrainingCenter)
                 .HasForeignKey(d => d.Ref_TrainingCenterId);

            entity.HasMany(d => d.Ref_Projects)
                 .WithOne(p => p.Ref_TrainingCenter)
                 .HasForeignKey(d => d.Ref_TrainingCenterId);
        }
    }
}