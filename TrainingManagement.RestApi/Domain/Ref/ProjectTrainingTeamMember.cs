using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class ProjectTrainingTeamMember : BaseEntity
    {
        public long TrainingTeamMemberId  { get; set; }
        public long ProjectId { get; set; }
        public string Role { get; set; }

        public virtual TrainingTeamMember TrainingTeamMember { get; set; }
        public virtual Project Project{ get; set; }
    }
}
