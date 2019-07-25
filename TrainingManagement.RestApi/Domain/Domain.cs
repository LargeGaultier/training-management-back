using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Domain
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
    }
}
