using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Base;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public partial class Run_EvaluationIndividual:BaseEntityHisto
    {
        public Run_EvaluationIndividual()
        {
            EvaluationProjectSkills = new HashSet<Run_EvaluationIndividualProjectSkill>();
        }
        public string Label { get; set; }
        public long? StudentId { get; set; }
        public long? ParentGroupEvaluationId { get; set; }
        public long? IntervenerId { get; set; }
        public long? EducationalManagerId { get; set; }
        public virtual Run_EducationalManager EducationalManager { get; set; }
        public virtual TrainingTeamMember Intervener { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<Run_EvaluationIndividualProjectSkill> EvaluationProjectSkills { get; set; }
        public virtual Run_EvaluationGroup ParentEvaluationGroup   { get; set; }
    }
}
