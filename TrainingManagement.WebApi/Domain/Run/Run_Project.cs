using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public class Run_Project : BaseEntityHisto
    {
        public Run_Project()
        {
            ProjectSkills = new HashSet<Run_ProjectSkill>();
            Run_ProjectTrainingTeamMembers = new HashSet<Run_ProjectTrainingTeamMember>();
        }
        public string Label { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public long TrainingCenterId { get; set; }
        public long ProjectId { get; set; }
        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual ICollection<Run_ProjectSkill> ProjectSkills { get; set; }
        public virtual ICollection<Run_ProjectTrainingTeamMember> Run_ProjectTrainingTeamMembers { get; set; }
        public virtual Project Project {get;set;}
    }

}
