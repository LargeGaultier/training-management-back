using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class Ref_TrainingYear : BaseEntityHisto
    {
        public Ref_TrainingYear()
        {
            Ref_TrainingYearBlocks = new HashSet<Ref_TrainingYearBlock>();
        }
        public string Label { get; set; }
        public int YearNumber { get; set; }

        public long Ref_DegreeId { get; set; }
        public virtual Ref_Degree Ref_Degree { get; set; }

        public virtual ICollection<Ref_TrainingYearBlock> Ref_TrainingYearBlocks { get; set; }

    }
}
