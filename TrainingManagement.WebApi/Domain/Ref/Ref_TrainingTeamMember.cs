using System;
using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Ref
{
    public partial class Ref_TrainingTeamMember : BaseEntityHisto
    {
        public Ref_TrainingTeamMember()
        {
            Ref_ProjectTrainingTeamMembers = new HashSet<Ref_ProjectTrainingTeamMember>();
            Ref_TagTrainingTeamMembers = new HashSet<Ref_TagTrainingTeamMember>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long Ref_TrainingCenterId { get; set; }
        public virtual Ref_TrainingCenter Ref_TrainingCenter { get; set; }

        public virtual ICollection<Ref_Project> Ref_Projects { get; set; }
        public virtual ICollection<Ref_ProjectTrainingTeamMember> Ref_ProjectTrainingTeamMembers { get; set; }
        public virtual ICollection<Ref_TagTrainingTeamMember> Ref_TagTrainingTeamMembers { get; set; }

    }
}
