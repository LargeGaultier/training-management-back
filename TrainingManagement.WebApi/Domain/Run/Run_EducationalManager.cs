using System;
using System.Collections.Generic;
using TrainingManagement.WebApi.Domain.Base;

namespace TrainingManagement.WebApi.Domain.Run
{
    public partial class Run_EducationalManager : BaseEntityHisto
    {
        public Run_EducationalManager()
        {
            Run_EvaluationIndividuals = new HashSet<Run_EvaluationIndividual>();
            Run_EvaluationGroups = new HashSet<Run_EvaluationGroup>();
        }
        public long IntervenerId { get; set; }
        public virtual ICollection<Run_EvaluationIndividual> Run_EvaluationIndividuals { get; set; }
        public virtual ICollection<Run_EvaluationGroup> Run_EvaluationGroups { get; set; }
        public virtual ICollection<Run_ProjetGroup> Run_ProjetGroups { get; set; }        
    }
}
