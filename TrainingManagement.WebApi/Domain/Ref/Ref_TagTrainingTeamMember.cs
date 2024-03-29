﻿using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public class Ref_TagTrainingTeamMember : BaseEntity
    {

        public long Ref_TagId { get; set; }
        public virtual Ref_Tag Ref_Tag { get; set; }
        public long Ref_TrainingTeamMemberId { get; set; }
        public virtual Ref_TrainingTeamMember Ref_TrainingTeamMember { get; set; }
    }
}
