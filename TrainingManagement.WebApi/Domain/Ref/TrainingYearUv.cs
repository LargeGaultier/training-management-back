using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class TrainingYearUv : BaseEntity
    {
        public long UvId { get; set; }
        public long TrainingYearId { get; set; }
        public virtual Uv Uv { get; set; }
        public virtual TrainingYear TrainingYear { get; set; }
    }
}
