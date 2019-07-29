using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class Tag : BaseEntityHisto
    {
        public Tag()
        {
            TagSkills = new HashSet<TagSkill>();
        }
        public string Name { get; set; }
        public virtual ICollection<TagSkill> TagSkills { get; set; }
    }
}
