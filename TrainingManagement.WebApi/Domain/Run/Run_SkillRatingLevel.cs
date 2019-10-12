using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain.Run
{
    public class Run_SkillRatingLevel : BaseEntityHisto
    {
        public Run_SkillRatingLevel()
        {
            Run_ProjectSkills = new HashSet<Run_ProjectSkill>();
        }
        public string Description { get; set; }
        public int Coefficient { get; set; }
        public long? Run_SkillId { get; set; }
        public long Run_RatingLevelId { get; set; }
        public long SkillRatingLevelId { get; set; }
        public virtual Ref_SkillRatingLevel SkillRatingLevel { get; set; }
        public virtual Run_RatingLevel Run_RatingLevel { get; set; }
        public virtual Run_Skill Run_Skill { get; set; }
        public virtual ICollection<Run_ProjectSkill> Run_ProjectSkills { get; set; }
    }
}