using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_Skill : BaseEntityHisto
    {
        public Run_Skill()
        {
            Run_SkillRatingLevels = new HashSet<Run_SkillRatingLevel>();
            Run_ProjectSkills = new HashSet<Run_ProjectSkill>();
            Run_UeSkills = new HashSet<Run_UeSkill>();
            //TagSkills = new HashSet<Run_TagSkill>();
        }
        public string Label { get; set; }
        public string Description { get; set; }
        public bool Validated { get; set; }
        public long TrainingCenterId { get; set; }
        public long SkillId { get; set; }
        public virtual Ref_TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<Run_SkillRatingLevel> Run_SkillRatingLevels { get; set; }
        public virtual ICollection<Run_ProjectSkill> Run_ProjectSkills { get; set; }
        public virtual ICollection<Run_UeSkill> Run_UeSkills { get; set; }
        public virtual Ref_Skill Skill { get; set; }
        //public virtual ICollection<Run_TagSkill> TagSkills { get; set; }

    }
}
