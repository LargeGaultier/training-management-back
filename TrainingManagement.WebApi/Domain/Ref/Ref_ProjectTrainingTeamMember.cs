using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public class Ref_ProjectTrainingTeamMember : BaseEntity
    {
       
        public string Role { get; set; }

        public long Ref_TrainingTeamMemberId { get; set; }
        public virtual Ref_TrainingTeamMember Ref_TrainingTeamMember { get; set; }
        public long Ref_ProjectId { get; set; }
        public virtual Ref_Project Ref_Project { get; set; }
    }
}
