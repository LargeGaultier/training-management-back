using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class Ref_TrainingCenter : BaseEntityHisto
    {
        public Ref_TrainingCenter()
        {
            Ref_Students = new HashSet<Ref_Student>();
            Ref_TrainingTeamMembers = new HashSet<Ref_TrainingTeamMember>();
            Ref_Degrees = new HashSet<Ref_Degree>();
            Ref_Skills = new HashSet<Ref_Skill>();
            Ref_Blocks = new HashSet<Ref_Block>();
            Ref_Projects = new HashSet<Ref_Project>();
        }
        public string Name { get; set; }

        public virtual ICollection<Ref_Student> Ref_Students { get; set; }
        public virtual ICollection<Ref_TrainingTeamMember> Ref_TrainingTeamMembers { get; set; }
        public virtual ICollection<Ref_Degree> Ref_Degrees { get; set; }
        public virtual ICollection<Ref_Skill> Ref_Skills { get; set; }
        public virtual ICollection<Ref_Block> Ref_Blocks { get; set; }
        public virtual ICollection<Ref_Project> Ref_Projects { get; set; }
    }
}
