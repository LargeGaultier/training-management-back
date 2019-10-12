using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_Ue : BaseEntityHisto
    {
        public Run_Ue()
        {
            Run_UeSkills = new HashSet<Run_UeSkill>();
        }
        public string Label { get; set; }
        public string Description { get; set; }
        public int Coefficient { get; set; }
        public long? Run_UvId { get; set; }
        public long UeId { get; set; }
        public virtual Run_Uv Run_Uv { get; set; }
        public virtual ICollection<Run_UeSkill> Run_UeSkills { get; set; }
        public virtual Ue Ue { get; set; }
    }
}
