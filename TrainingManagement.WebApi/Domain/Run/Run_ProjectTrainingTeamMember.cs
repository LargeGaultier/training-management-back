using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_ProjectTrainingTeamMember : BaseEntityHisto
    {
        public long TrainingTeamMemberId { get; set; }
        public long ProjectId { get; set; }
        public string Role { get; set; }
        public virtual TrainingTeamMember TrainingTeamMember { get; set; }
        public virtual Run_Project Project { get; set; }
    }
}
