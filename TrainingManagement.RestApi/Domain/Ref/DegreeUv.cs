

using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class DegreeUv : BaseEntity
    {
        public int DegreeId{ get; set; }
        public int UvId { get; set; }
        public virtual Degree Degree { get; set; }
        public virtual Uv Uv { get; set; }

    }
}
