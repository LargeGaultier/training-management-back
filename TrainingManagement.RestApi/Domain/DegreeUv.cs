using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Domain
{
    public class DegreeUv
    {
        public int id{ get; set; }
        public int DegreeId{ get; set; }
        public int UvId { get; set; }

        public Degree Degree { get; set; }
        public Uv Uv { get; set; }

    }
}
