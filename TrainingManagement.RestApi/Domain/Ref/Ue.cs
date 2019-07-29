using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Ue : BaseEntityHisto
    {
        public Ue()
        {
            UeSkills = new HashSet<UeSkill>();
        }
        public string Label { get; set; }
        public string Description { get; set; }
        public int Coefficient { get; set; }
        public long? UvId { get; set; }
        public virtual Uv Uv { get; set; }
        public virtual ICollection<UeSkill> UeSkills { get; set; }
    }
}
