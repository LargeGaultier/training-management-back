using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class TagSkill : BaseEntity
    {
        public long TagId { get; set; }
        public long SkillId { get; set; }
        public Tag Tag { get; set; }
        public Skill Skill { get; set; }
    }
}
