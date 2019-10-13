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

        public static List<RefDegreeDTO> GetMock()
        {
            return new List<RefDegreeDTO>()
            {
                new RefDegreeDTO()
                {
                    Id=  1,
                    Name = "Diiage dev",
                    TrainingYearDTOs = new List<RefTrainingYearDTO>()
                    {
                        new RefTrainingYearDTO()
                        {
                            Id=1,
                            Label = "Diiage dev 1",
                            YearNumber = 1
                        },
                        new RefTrainingYearDTO()
                        {
                            Id=2,
                            Label = "Diiage dev 2",
                            YearNumber = 2
                        },
                        new RefTrainingYearDTO()
                        {
                            Id=3,
                            Label = "Diiage dev 3",
                            YearNumber = 3
                        },
                    }

                },
                new RefDegreeDTO()
                {
                    Id=  1,
                    Name = "Diiage dev",
                    TrainingYearDTOs = new List<RefTrainingYearDTO>()
                    {
                        new RefTrainingYearDTO()
                        {
                            Id=4,
                            Label = "Diiage réseau 1",
                            YearNumber = 1
                        },
                        new RefTrainingYearDTO()
                        {
                            Id=5,
                            Label = "Diiage réseau 2",
                            YearNumber = 2
                        },
                        new RefTrainingYearDTO()
                        {
                            Id=6,
                            Label = "Diiage réseau 3",
                            YearNumber = 3
                        },
                    }

                }
            };
        }

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
