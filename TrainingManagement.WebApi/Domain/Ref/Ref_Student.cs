using System;
using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public partial class Ref_Student : BaseEntityHisto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Photo { get; set; }

        public long Ref_TrainingCenterId { get; set; }
        public virtual Ref_TrainingCenter Ref_TrainingCenter { get;set;}
        
    }
}
