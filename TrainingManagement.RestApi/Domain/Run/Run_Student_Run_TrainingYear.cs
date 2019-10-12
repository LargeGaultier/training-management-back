using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_Student_Run_TrainingYear : BaseEntity
    {
        public long StudentId { get; set; }
        public long RunTrainingYearId { get; set; }
        public virtual Run_TrainingYear Run_TrainingYear { get; set; }
        public virtual Ref_Student Student { get; set; }

    }
}
