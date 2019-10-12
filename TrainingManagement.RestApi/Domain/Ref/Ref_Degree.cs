using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class Ref_Degree : BaseEntityHisto
    {
        public Ref_Degree()
        {
            Ref_DegreeBlocks = new HashSet<Ref_DegreeBlock>();
            Ref_TrainingYears = new HashSet<Ref_TrainingYear>();
        }
        public string Name{ get; set; }

        public long? Ref_TrainingCenterId { get; set; }
        public virtual Ref_TrainingCenter Ref_TrainingCenter { get; set; }

        public virtual ICollection<Ref_DegreeBlock> Ref_DegreeBlocks { get; set; }
        public virtual ICollection<Ref_TrainingYear> Ref_TrainingYears { get; set; }
    }
}
