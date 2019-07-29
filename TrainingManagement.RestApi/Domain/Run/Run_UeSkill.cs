using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_UeSkill : BaseEntity
    {
        public int UeId { get; set; }
        public int SkillId { get; set; }
        public virtual Run_Skill Skill { get; set; }
        public virtual Run_Ue Ue { get; set; }
    }
}
