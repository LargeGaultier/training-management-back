using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class Ref_TagSkill : BaseEntity
    {
        
        public long Ref_TagId { get; set; }
        public Ref_Tag Ref_Tag { get; set; }
        public long Ref_SkillId { get; set; }
        public Ref_Skill Ref_Skill { get; set; }
    }
}
