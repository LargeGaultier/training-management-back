using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
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
