using System;
using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain.Run
{
    public partial class Run_EvaluationIndividualProjectSkill : BaseEntityHisto
    {
        public long Run_EvaluationIndividualId { get; set; }
        public long RunProjectSkill_Id { get; set; }
        public long? LevelReachedId { get; set; }


        public virtual Run_EvaluationIndividual Run_EvaluationIndividual { get; set; }
        public virtual Run_SkillRatingLevel Run_SkillRatingLevel { get; set; }
        public virtual Run_ProjectSkill Run_ProjectSkill { get; set; }
    }
}
