using System;
using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain.Run
{
    public partial class Run_StudentGroup : BaseEntityHisto
    {
        public int StudentId { get; set; }
        public int ProjectGroupId { get; set; }

        public virtual Run_ProjetGroup ProjetGroup { get; set; }
        public virtual Ref_Student Student { get; set; }
    }
}
