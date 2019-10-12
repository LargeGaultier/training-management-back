

using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class DegreeUv : BaseEntity
    {
        public long DegreeId{ get; set; }
        public long UvId { get; set; }
        public virtual Degree Degree { get; set; }
        public virtual Uv Uv { get; set; }

    }
}
