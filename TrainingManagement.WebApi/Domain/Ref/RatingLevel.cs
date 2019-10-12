using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public class RatingLevel : BaseEntityHisto
    {
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
