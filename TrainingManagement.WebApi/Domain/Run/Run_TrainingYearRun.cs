using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Domain.Run
{
    public class Run_TrainingYear :BaseEntityHisto
    {
        public Run_TrainingYear()
        {
            Students = new HashSet<Ref_Student>();
        }

        public string Name { get; set; }
        public long ScholarYearId { get; set; }
        public long TrainingYearId { get; set; } 
        public virtual ICollection<Ref_Student>  Students { get; set; }
        public virtual Ref_TrainingYear TrainingYear { get; set; }
    }
}
