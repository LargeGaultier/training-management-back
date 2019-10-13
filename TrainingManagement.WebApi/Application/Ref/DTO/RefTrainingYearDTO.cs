using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Application.Ref.DTO
{
    public class RefTrainingYearDTO
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public int YearNumber { get; set; }

        public static RefTrainingYearDTO ToDTO(Ref_TrainingYear year)
        {
            return new RefTrainingYearDTO()
            {
                YearNumber = year.YearNumber,
                Id = year.Id,
                Label = year.Label
            };
        }
        }
}
