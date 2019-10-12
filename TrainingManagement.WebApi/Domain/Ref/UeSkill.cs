using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class UeSkill:BaseEntity
    {
        public int UeId { get; set; }
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual Ue Ue { get; set; }
    }
}
