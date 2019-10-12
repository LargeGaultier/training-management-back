using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_RatingLevel : BaseEntity
    {
        public string Label { get; set; }
        public string Description { get; set; }

        public long SkillLevelId { get; set; }
        public virtual Ref_RatingLevel RatingLevel { get;set;}

    }
}
