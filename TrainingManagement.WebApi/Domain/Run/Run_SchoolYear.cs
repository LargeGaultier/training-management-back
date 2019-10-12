using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Run
{
    public class Run_SchoolYear : BaseEntityHisto
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Run_Promotion> Run_Promotions { get; set; }
    }
}
