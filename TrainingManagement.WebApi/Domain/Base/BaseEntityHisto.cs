using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Domain.Base
{
    public abstract class BaseEntityHisto : BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string CreatorLogin { get; set; }
        public string LastUpdaterLogin { get; set; }
    }
}
