using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Skill
    {
        public Skill()
        {
            Levels = new HashSet<Level>();
            ProjectSkills = new HashSet<ProjectSkill>();
            UeSkills = new HashSet<UeSkill>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public bool Validated { get; set; }
        public int? DomainId { get; set; }
        public int TrainingCenterId { get; set; }

        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual Domain Domain { get; set; }
        public virtual ICollection<Level> Levels { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
        public virtual ICollection<UeSkill> UeSkills { get; set; }


    }
}
