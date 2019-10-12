using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class Degree : BaseEntityHisto
    {
        public Degree()
        {
            DegreeUvs = new HashSet<DegreeUv>();
            TrainingYears = new HashSet<TrainingYear>();
        }
        public string Name{ get; set; }
        public int TrainingCenterId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<DegreeUv> DegreeUvs { get; set; }
        public virtual ICollection<TrainingYear> TrainingYears { get; set; }
    }
}
