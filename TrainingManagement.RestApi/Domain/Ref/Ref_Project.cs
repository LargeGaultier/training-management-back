using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;

namespace TrainingManagement.RestApi.Domain.Ref
{
    public partial class Ref_Project : BaseEntityHisto
    {
        public Ref_Project()
        {
            Ref_ProjectSkills = new HashSet<Ref_ProjectSkill>();
            Ref_ProjectTrainingTeamMembers = new HashSet<Ref_ProjectTrainingTeamMember>();
        }

        public string Label { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public long Ref_TrainingCenterId { get; set; }
        public virtual Ref_TrainingCenter Ref_TrainingCenter { get; set; }
        public long? Ref_TrainingTeamMemberId { get; set; }
        public virtual Ref_TrainingTeamMember Ref_TrainingTeamMember { get; set; }

        public virtual ICollection<Ref_ProjectSkill> Ref_ProjectSkills { get; set; }
        public virtual ICollection<Ref_ProjectTrainingTeamMember> Ref_ProjectTrainingTeamMembers { get; set; }
    }
}
