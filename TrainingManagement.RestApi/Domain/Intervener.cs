using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Intervener
    {
        public Intervener()
        {
            Evaluations = new HashSet<Evaluation>();
            Projects = new HashSet<Project>();
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Office365Id { get; set; }
        public bool Activated { get; set; }
        public int TrainingCenterId { get; set; }

        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
