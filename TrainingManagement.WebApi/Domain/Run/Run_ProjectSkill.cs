using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain.Run
{
    public class Run_ProjectSkill: BaseEntityHisto
    {
        public Run_ProjectSkill()
        {

        }
    public long Run_ProjectId { get; set; }
    public long SkillId { get; set; }
    public long Coefficient { get; set; }
    public long RequiredLevelId { get; set; }
    public long projectSkillId { get; set; }
    public virtual Ref_ProjectSkill ProjectSkill { get; set; }
    public virtual Run_Project Run_Project { get; set; }
    public virtual Run_SkillRatingLevel Run_RequiredLevel { get; set; }
    public virtual Run_Skill Run_Skill { get; set; }
}
}
