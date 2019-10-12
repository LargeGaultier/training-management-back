using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public partial class Ref_Ue : BaseEntityHisto
    {
        public Ref_Ue()
        {
            Ref_UeSkills = new HashSet<Ref_UeSkill>();
        }
        public string Label { get; set; }
        public string Description { get; set; }
        public int Coefficient { get; set; }

        public long? Ref_UvId { get; set; }
        public virtual Ref_Uv Ref_Uv { get; set; }

        public virtual ICollection<Ref_UeSkill> Ref_UeSkills { get; set; }
    }
}
