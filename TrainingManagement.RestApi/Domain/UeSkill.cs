using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class UeSkill
    {
        public int IdUe { get; set; }
        public int IdSkill { get; set; }

        public virtual Skill IdSkillNavigation { get; set; }
        public virtual Ue IdUeNavigation { get; set; }
    }
}
