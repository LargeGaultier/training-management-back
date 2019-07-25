using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Domain
{
    public class Degree
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int TrainingCenterId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<DegreeUv> DegreeUvs { get; set; }
    }
}
