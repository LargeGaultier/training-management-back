using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class EducationalManager
    {
        public EducationalManager()
        {
            Evaluations = new HashSet<Evaluation>();
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Office365Id { get; set; }
        public bool Activated { get; set; }

        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
