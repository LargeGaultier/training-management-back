using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class ProjectSkill
    {
        public ProjectSkill()
        {
            EvaluationProjectSkills = new HashSet<EvaluationProjectSkill>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int SkillId { get; set; }
        public int Coefficient { get; set; }
        public bool? Validated { get; set; }
        public int? RequiredLevelId { get; set; }

        public virtual Project Project { get; set; }
        public virtual Level RequiredLevel { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual ICollection<EvaluationProjectSkill> EvaluationProjectSkills { get; set; }
    }
}
