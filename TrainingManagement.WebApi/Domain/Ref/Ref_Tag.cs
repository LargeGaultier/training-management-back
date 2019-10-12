using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public class Ref_Tag : BaseEntityHisto
    {
        public Ref_Tag()
        {
            Ref_TagSkills = new HashSet<Ref_TagSkill>();
            Ref_TagTrainingTeamMembers = new HashSet<Ref_TagTrainingTeamMember>();
        }
        public string Name { get; set; }

        public virtual ICollection<Ref_TagSkill> Ref_TagSkills { get; set; }
        public virtual ICollection<Ref_TagTrainingTeamMember> Ref_TagTrainingTeamMembers { get; set; }
    }
}
