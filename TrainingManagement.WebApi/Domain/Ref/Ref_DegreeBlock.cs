

using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public class Ref_DegreeBlock : BaseEntity
    {
        
        public long Ref_DegreeId { get; set; }
        public virtual Ref_Degree Ref_Degree { get; set; }

        public long Ref_BlockId { get; set; }
        public virtual Ref_Block Ref_Block { get; set; }

    }
}
