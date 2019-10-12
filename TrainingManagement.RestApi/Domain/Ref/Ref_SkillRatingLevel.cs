using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Ref_SkillRatingLevel : BaseEntityHisto
    {
        public Ref_SkillRatingLevel()
        {
            Ref_ProjectSkills = new HashSet<Ref_ProjectSkill>();
        }

        public string Description { get; set; }
        public int Coefficient { get; set; }
        
        public long Ref_RatingLevelId { get; set; }
        public virtual Ref_RatingLevel Ref_RatingLevel { get;set;}
        public long Ref_SkillId { get; set; }
        public virtual Ref_Skill Ref_Skill { get; set; }

        public virtual ICollection<Ref_ProjectSkill> Ref_ProjectSkills { get; set; }
    }
}
