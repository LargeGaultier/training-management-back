using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public partial class Run_StudentGroup : BaseEntityHisto
    {
        public int StudentId { get; set; }
        public int ProjectGroupId { get; set; }

        public virtual Run_ProjetGroup ProjetGroup { get; set; }
        public virtual Student Student { get; set; }
    }
}
