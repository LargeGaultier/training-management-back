using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Project : BaseEntityHisto
    {
        public Project()
        {
            ProjectSkills = new HashSet<ProjectSkill>();
            ProjectTrainingTeamMembers = new HashSet<ProjectTrainingTeamMember>();
        }

        public string Label { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public long TrainingCenterId { get; set; }

        public virtual TrainingCenter TrainingCenter { get; set; }
        public virtual TrainingTeamMember Intervener { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
        public virtual ICollection<ProjectTrainingTeamMember> ProjectTrainingTeamMembers { get; set; }
    }
}
