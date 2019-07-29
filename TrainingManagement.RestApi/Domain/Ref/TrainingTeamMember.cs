using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class TrainingTeamMember : BaseEntityHisto
    {
        public TrainingTeamMember()
        {
            ProjectTrainingTeamMembers = new HashSet<ProjectTrainingTeamMember>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TrainingCenterId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<ProjectTrainingTeamMember> ProjectTrainingTeamMembers { get; set; }
    }
}
