using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class TagTrainingTeamMember : BaseEntity
    {
        public long TrainingTeamMemberId { get; set; }
        public long TagId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual TrainingTeamMember TrainingTeamMember { get; set; }
    }
}
