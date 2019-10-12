using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Ref_Skill : BaseEntityHisto
    {
        public Ref_Skill()
        {
            Ref_Levels = new HashSet<Ref_SkillRatingLevel>();
            Ref_ProjectSkills = new HashSet<Ref_ProjectSkill>();
            Ref_UeSkills = new HashSet<Ref_UeSkill>();
            Ref_TagSkills = new HashSet<Ref_TagSkill>();
        }
        public string Label { get; set; }
        public string Description { get; set; }

        public long Ref_TrainingCenterId { get; set; }
        public virtual Ref_TrainingCenter Ref_TrainingCenter { get; set; }

        public virtual ICollection<Ref_SkillRatingLevel> Ref_Levels { get; set; }
        public virtual ICollection<Ref_ProjectSkill> Ref_ProjectSkills { get; set; }
        public virtual ICollection<Ref_UeSkill> Ref_UeSkills { get; set; }
        public virtual ICollection<Ref_TagSkill> Ref_TagSkills { get; set; }
    }
}
