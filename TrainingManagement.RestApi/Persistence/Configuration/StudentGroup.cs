﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainingManagement.RestApi.Domain
{
    public partial class StudentGroupConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> entity)
        {
            entity.HasKey(e => new { e.GroupId, e.StudentId });

            entity.HasOne(d => d.Group)
                .WithMany(p => p.StudentGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Student)
                .WithMany(p => p.StudentGroups)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}