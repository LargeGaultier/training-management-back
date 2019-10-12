using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public partial class Ref_UeSkill:BaseEntity
    {

        public long Ref_SkillId { get; set; }
        public virtual Ref_Skill Ref_Skill { get; set; }
        public long Ref_UeId { get; set; }
        public virtual Ref_Ue Ref_Ue { get; set; }
    }
}
