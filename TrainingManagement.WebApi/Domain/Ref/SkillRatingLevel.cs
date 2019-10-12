using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class SkillRatingLevel : BaseEntityHisto
    {
        public SkillRatingLevel()
        {
            ProjectSkills = new HashSet<ProjectSkill>();
        }

        public string Description { get; set; }
        public int Coefficient { get; set; }
        public long? IdSkill { get; set; }
        public int RatingLevelId { get; set; }
        public virtual RatingLevel RatingLevel {get;set;}
        public virtual Skill Skill { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
    }
}
