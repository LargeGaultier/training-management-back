using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class StudentGroup
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Student Student { get; set; }
    }
}
