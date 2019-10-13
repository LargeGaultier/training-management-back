using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Application.Ref.DTO
{
    public class RefDegreeDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<RefTrainingYearDTO> TrainingYearDTOs { get; set; }

        public static RefDegreeDTO ToDTO(Ref_Degree t)
        {
            var result = new RefDegreeDTO
            {
                Id = t.Id,
                Name = t.Name
            };
            return result;
        }

        public static Expression<Func<Ref_Degree, RefDegreeDTO>> Projection
        {
            get
            {
                return t => new RefDegreeDTO
                {
                    Id = t.Id,
                    Name = t.Name
                };
            }
        }
    }
}
