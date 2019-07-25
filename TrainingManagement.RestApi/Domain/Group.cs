using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Group
    {
        public Group()
        {
            StudentGroups = new HashSet<StudentGroup>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string TeamsChannelId { get; set; }
        public int? ProjectId { get; set; }
        public bool? EvaluationCreated { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
