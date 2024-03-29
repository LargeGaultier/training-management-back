﻿using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain.Run
{
    public class Run_ProjectTrainingTeamMember : BaseEntityHisto
    {
        public long TrainingTeamMemberId { get; set; }
        public long ProjectId { get; set; }
        public string Role { get; set; }
        public virtual Ref_TrainingTeamMember TrainingTeamMember { get; set; }
        public virtual Run_Project Project { get; set; }
    }
}
