using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Ref_Uv : BaseEntityHisto
    {
        public Ref_Uv()
        {
            Ref_Ues = new HashSet<Ref_Ue>();
            Ref_Uvs = new HashSet<Ref_Uv>();
            Ref_TrainingYearBlocks = new HashSet<Ref_TrainingYearBlock>();
        }
        public string Label { get; set; }
        public int Coefficient { get; set; }
        public string Description { get; set; }

        public long? Ref_BlockId { get; set; }
        public virtual Ref_Block Ref_Block { get; set; }

        public long? Ref_UvParentId { get; set; }
        public virtual Ref_Uv Ref_UvParent { get; set; }

        public virtual ICollection<Ref_Uv> Ref_Uvs { get; set; }
        public virtual ICollection<Ref_Ue> Ref_Ues { get; set; }
        public virtual ICollection<Ref_TrainingYearBlock> Ref_TrainingYearBlocks { get; set; }

    }
}
