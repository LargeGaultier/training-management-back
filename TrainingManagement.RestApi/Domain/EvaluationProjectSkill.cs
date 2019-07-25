using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class EvaluationProjectSkill
    {
        public int IdEvaluation { get; set; }
        public int IdProjectSkill { get; set; }
        public int? IdLevelReached { get; set; }

        public virtual Evaluation IdEvaluationNavigation { get; set; }
        public virtual Level IdLevelReachedNavigation { get; set; }
        public virtual ProjectSkill IdProjectSkillNavigation { get; set; }
    }
}
