using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain;
using TrainingManagement.RestApi.Domain.Ref;
using TrainingManagement.RestApi.Domain.Run;

namespace TrainingManagement.RestApi.Persistence.Configuration
{
    public partial class PromotionConfiguration : IEntityTypeConfiguration<Run_Promotion>
    {
        public void Configure(EntityTypeBuilder<Run_Promotion> entity)
        {
          
        }
    }
}
