using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Ref_Block : BaseEntityHisto
    {
        public Ref_Block()
        {
            Ref_Uvs = new HashSet<Ref_Uv>();
            Ref_DegreeBlocks = new HashSet<Ref_DegreeBlock>();
            Ref_TrainingYearBlocks = new HashSet<Ref_TrainingYearBlock>();
        }
        public string Label { get; set; }
        public int Coefficient { get; set; }
        public string Description { get; set; }

        public long? Ref_TrainingCenterId { get; set; }
        public virtual Ref_TrainingCenter Ref_TrainingCenter { get; set; }

        public virtual ICollection<Ref_Uv> Ref_Uvs { get; set; }
        public virtual ICollection<Ref_DegreeBlock> Ref_DegreeBlocks { get;set;}
        public virtual ICollection<Ref_TrainingYearBlock> Ref_TrainingYearBlocks { get; set; }

    }
}
