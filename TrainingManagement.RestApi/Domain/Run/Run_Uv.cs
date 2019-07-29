using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_Uv : BaseEntityHisto
    {
        public Run_Uv()
        {
            Run_Ues = new HashSet<Run_Ue>();
            //TrainingYearUvs = new HashSet<TrainingYearUv>();
        }
        public string Label { get; set; }
        public int Coefficient { get; set; }
        public string Description { get; set; }
        public long TrainingCenterId { get; set; }
        public long UvId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<Run_Ue> Run_Ues { get; set; }
        public virtual Uv Uv { get; set; }
        //public virtual ICollection<DegreeUv> DegreeUvs { get; set; }
        //public virtual ICollection<TrainingYearUv> TrainingYearUvs { get; set; }

    }
}
