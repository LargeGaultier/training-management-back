using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
