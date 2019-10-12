using System;
using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public partial class Ref_ProjectSkill : BaseEntityHisto
    {
        public long Coefficient { get; set; }
        
        public long Ref_ProjectId { get; set; }
        public virtual Ref_Project Ref_Project { get; set; }
        public long Ref_SkillRatingLevelId { get; set; }
        public virtual Ref_SkillRatingLevel Ref_SkillRatingLevel { get; set; }
        public long Ref_SkillId { get; set; }
        public virtual Ref_Skill Ref_Skill { get; set; }
    }
}
