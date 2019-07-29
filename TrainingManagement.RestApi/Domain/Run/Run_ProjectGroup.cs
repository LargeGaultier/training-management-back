using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public partial class Run_ProjetGroup: BaseEntityHisto
    {
        public Run_ProjetGroup()
        {
            Run_StudentGroups = new HashSet<Run_StudentGroup>();
        }
        public string Label { get; set; }
        public string Description { get; set; }
        public long Run_ProjectId { get; set; }
        public virtual Run_Project RunProject { get; set; }
        public virtual ICollection<Run_StudentGroup> Run_StudentGroups { get; set; }
    }
}
