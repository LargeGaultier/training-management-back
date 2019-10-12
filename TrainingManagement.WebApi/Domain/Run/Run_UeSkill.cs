using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Run
{
    public class Run_UeSkill : BaseEntity
    {
        public int Run_UeId { get; set; }
        public int Run_SkillId { get; set; }
        public virtual Run_Skill Skill { get; set; }
        public virtual Run_Ue Ue { get; set; }
    }
}
