using System;
using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain.Run
{
    public partial class Run_EvaluationGroupProjectSkill : BaseEntityHisto
    {
        public long Run_EvaluationGroupId { get; set; }
        public long RunProjectSkill_Id { get; set; }
        public long? LevelReachedId { get; set; }


        public virtual Run_EvaluationGroup Run_EvaluationGroup { get; set; }
        public virtual Run_SkillRatingLevel Run_SkillRatingLevel { get; set; }
        public virtual Run_ProjectSkill Run_ProjectSkill { get; set; }
    }
}
