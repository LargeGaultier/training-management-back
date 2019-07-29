using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class TrainingYear : BaseEntityHisto
    {
        public string Label { get; set; }
        public int YearNumber { get; set; }
        public long DegreeId { get; set; }
        public virtual Degree Degree { get; set; }
        public virtual ICollection<TrainingYearUv> TrainingYearUvs { get; set; }

    }
}
