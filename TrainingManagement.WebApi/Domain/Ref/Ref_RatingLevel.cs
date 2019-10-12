using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public class Ref_RatingLevel : BaseEntityHisto
    {
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
