using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Ue
    {
        public Ue()
        {
            UeSkills = new HashSet<UeSkill>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public int Coefficient { get; set; }
        public int? UvId { get; set; }
        public bool? Active { get; set; }

        public virtual Uv Uv { get; set; }
        public virtual ICollection<UeSkill> UeSkills { get; set; }
    }
}
