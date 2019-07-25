using System;
using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int? EducationalManagerId { get; set; }
        public int? IntervenerId { get; set; }
        public int? StudentId { get; set; }

        public virtual EducationalManager EducationalManager { get; set; }
        public virtual Intervener Intervener { get; set; }
        public virtual Student Student { get; set; }
    }
}
