using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Student
    {
        public Student()
        {
            Evaluations = new HashSet<Evaluation>();
            Roles = new HashSet<Role>();
            StudentGroups = new HashSet<StudentGroup>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Activated { get; set; }
        public int ClassId { get; set; }
        public string Mail { get; set; }
        public int TrainingCenterId { get; set; }

        public virtual TrainingCenter TrainingCenter {get;set;}
        public virtual Class Class { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
