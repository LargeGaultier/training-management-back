using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public class Ref_TrainingYearBlock : BaseEntity
    {
        
        public long Ref_BlockId { get; set; }
        public virtual Ref_Block Ref_Block { get; set; }
        public long Ref_TrainingYearId { get; set; }
        public virtual Ref_TrainingYear Ref_TrainingYear { get; set; }
        public long Ref_UvId { get; set; }
        public virtual Ref_Uv Ref_Uv { get; set; }
    }
}
