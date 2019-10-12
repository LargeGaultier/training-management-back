using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class TrainingCenter : BaseEntityHisto
    {
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<TrainingTeamMember> Interveners { get; set; }
        public virtual ICollection<Degree> Degrees { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Uv> Uvs { get; set; }
        public virtual ICollection<Project> Projects {get;set;}
    }
}
