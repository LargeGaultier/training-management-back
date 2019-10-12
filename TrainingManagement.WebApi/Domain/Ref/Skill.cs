using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Skill : BaseEntityHisto
    {
        public Skill()
        {
            Levels = new HashSet<SkillRatingLevel>();
            ProjectSkills = new HashSet<ProjectSkill>();
            UeSkills = new HashSet<UeSkill>();
            TagSkills = new HashSet<TagSkill>();
        }
        public string Label { get; set; }
        public string Description { get; set; }
        public bool Validated { get; set; }
        public long TrainingCenterId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<SkillRatingLevel> Levels { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
        public virtual ICollection<UeSkill> UeSkills { get; set; }
        public virtual ICollection<TagSkill> TagSkills { get; set; }
    }
}
