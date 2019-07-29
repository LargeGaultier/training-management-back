using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain
{
    public partial class UeConfiguration : IEntityTypeConfiguration<Ue>
    {
        public void Configure(EntityTypeBuilder<Ue> entity)
        {
            entity.HasOne(d => d.Uv)
                   .WithMany(p => p.Ues)
                   .HasForeignKey(d => d.UvId);
        }
    }
}
