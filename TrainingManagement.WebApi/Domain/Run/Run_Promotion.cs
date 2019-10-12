using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public partial class Run_Promotion :  BaseEntityHisto
    {
        public Run_Promotion()
        {
            Students = new HashSet<Student>();
        }
        public string Label { get; set; }
        public int Year { get; set; }
        public long TrainingCenterId { get; set; }
        public long RunTrainingYearId { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual Run_TrainingYear Run_TrainingYear { get; set; }

        
    }
}
