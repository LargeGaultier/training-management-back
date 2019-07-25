using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Level
    {
        public Level()
        {
            EvaluationProjectSkills = new HashSet<EvaluationProjectSkill>();
            ProjectSkills = new HashSet<ProjectSkill>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Coefficient { get; set; }
        public int? IdSkill { get; set; }

        public virtual Skill IdSkillNavigation { get; set; }
        public virtual ICollection<EvaluationProjectSkill> EvaluationProjectSkills { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
    }
}
