using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class ProjectSkill : BaseEntityHisto
    {
        public ProjectSkill()
        {
           
        }
        public long ProjectId { get; set; }
        public long SkillId { get; set; }
        public long Coefficient { get; set; }
        public long RequiredLevelId { get; set; }
        public virtual Project Project { get; set; }
        public virtual SkillRatingLevel RequiredLevel { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
