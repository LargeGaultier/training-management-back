using System;
using System.Collections.Generic;
using TrainingManagement.RestApi.Domain.Ref;

namespace TrainingManagement.RestApi.Domain.Run
{
    public partial class Run_EvaluationGroup
    {
        public Run_EvaluationGroup()
        {
            EvaluationProjectSkills = new HashSet<Run_EvaluationIndividualProjectSkill>();
            EvaluationIndividuals = new HashSet<Run_EvaluationIndividual>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public long? IntervenerId { get; set; }
        public long? EducationalManagerId { get; set; }
        public long? GroupId { get; set; }
        public virtual Run_ProjetGroup Group { get; set; }
        public virtual Run_EducationalManager EducationalManager { get; set; }
        public virtual Ref_TrainingTeamMember Intervener { get; set; }
        public virtual Run_EvaluationGroup ParentEvaluation { get; set; }
        public virtual ICollection<Run_EvaluationIndividualProjectSkill> EvaluationProjectSkills { get; set; }
        public virtual ICollection<Run_EvaluationIndividual> EvaluationIndividuals { get; set; }
    }
}
