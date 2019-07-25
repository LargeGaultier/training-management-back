using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Evaluation
    {
        public Evaluation()
        {
            EvaluationProjectSkills = new HashSet<EvaluationProjectSkill>();
            InverseParentEvaluations = new HashSet<Evaluation>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public bool Validated { get; set; }
        public int? StudentId { get; set; }
        public int? CriterionId { get; set; }
        public int? ParentEvaluationId { get; set; }
        public int? IntervenerId { get; set; }
        public int? EducationalManagerId { get; set; }

        public virtual EducationalManager EducationalManager { get; set; }
        public virtual Intervener Intervener { get; set; }
        public virtual Evaluation ParentEvaluation { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<EvaluationProjectSkill> EvaluationProjectSkills { get; set; }
        public virtual ICollection<Evaluation> InverseParentEvaluations { get; set; }
    }
}
