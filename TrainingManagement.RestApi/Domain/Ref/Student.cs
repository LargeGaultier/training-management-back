using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Student : BaseEntityHisto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Photo { get; set; }
        public int TrainingCenterId { get; set; }
        public virtual TrainingCenter TrainingCenter {get;set;}
        
    }
}
