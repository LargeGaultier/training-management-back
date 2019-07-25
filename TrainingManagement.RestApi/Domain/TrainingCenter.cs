using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Domain
{
    public class TrainingCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Intervener> Interveners { get; set; }
        public virtual ICollection<Degree> Degrees { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Uv> Uvs { get; set; }
        public virtual ICollection<Project> Projects {get;set;}
    }
}
