using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Uv : BaseEntityHisto
    {
        public Uv()
        {
            Ues = new HashSet<Ue>();
            Uvs = new HashSet<Uv>();
            TrainingYearUvs = new HashSet<TrainingYearUv>();
        }
        public string Label { get; set; }
        public int Coefficient { get; set; }
        public string Description { get; set; }
        public long? TrainingCenterId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }

        public virtual ICollection<Uv> Uvs { get; set; }
        public virtual ICollection<Ue> Ues { get; set; }
        public virtual ICollection<DegreeUv> DegreeUvs {get;set;}
        public virtual ICollection<TrainingYearUv> TrainingYearUvs { get; set; }

    }
}
