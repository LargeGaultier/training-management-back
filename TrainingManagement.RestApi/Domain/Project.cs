using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Project
    {
        public Project()
        {
            Groups = new HashSet<Group>();
            ProjectSkills = new HashSet<ProjectSkill>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? IntervenerId { get; set; }
        public bool? Active { get; set; }
        public int TrainingCenterId { get; set; }

        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual Intervener Intervener { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
    }
}
