using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Uv
    {
        public Uv()
        {
            Ues = new HashSet<Ue>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public int Coefficient { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public int TrainingCenterId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<Ue> Ues { get; set; }
        public virtual ICollection<DegreeUv> DegreeUvs {get;set;}
    }
}
