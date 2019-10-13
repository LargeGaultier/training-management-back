using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TrainingManagement.WebApi.Domain.Ref;
using System.Linq;

namespace TrainingManagement.WebApi.Application.Ref.DTO
{
    public class RefBlockDTO
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public long? TrainingCenterId { get; set; }
        public List<RefDegreeDTO> RefDegrees { get;set;}
        public List<RefUvDTO> RefUvs { get; set; }

        public static RefBlockDTO ToDTO(Ref_Block t)
        {
            var result = new RefBlockDTO
            {
                Id = t.Id,
                Label = t.Label,
                Description = t.Description,
                TrainingCenterId = t.Ref_TrainingCenterId
            };
            result.RefDegrees.AddRange(t.Ref_DegreeBlocks.Select(e=>e.Ref_Degree).Select(e => RefDegreeDTO.ToDTO(e)));
            result.RefUvs.AddRange(t.Ref_Uvs.Select(e => RefUvDTO.ToDTO(e)));
            return result;
        }

        public static Expression<Func<Ref_Block, RefBlockDTO>> Projection
        {
            get
            {
                return t => new RefBlockDTO
                {
                    Id = t.Id,
                    Label = t.Label,
                    Description = t.Description
                };
            }
        }

        public static List<RefBlockDTO> GetMock(long id)
        {
            
            List<RefBlockDTO> result = new List<RefBlockDTO>();

            for (int i = 0; i < 10; i++)
            {
                RefBlockDTO block = new RefBlockDTO()
                {
                    Id = i,
                    RefDegrees = new List<RefDegreeDTO>()
                    {
                        new RefDegreeDTO()
                        {
                            Id = 1,
                            Name = "Diiage Dev" + id
                        },
                        new RefDegreeDTO()
                        {
                            Id = 1,
                            Name = "Diiage Reseau"
                        },
                    },
                    Description = "Description Block de dev " + i,
                    Label = "UV dev" + i,
                    TrainingCenterId = 1


                };

                block.RefUvs = new List<RefUvDTO>();

                for (int j = 0; j < 3; j++)
                {
                    RefUvDTO uv = new RefUvDTO()
                    {
                        Id = j,
                        Description = "description UvDev" + j,
                        Label = "UvDev" + j,
                        ChildrenRefUvs = new List<RefUvDTO>()
                        {
                            new RefUvDTO()
                            {
                                Id = j+10,
                                Description = "description sub uv " + (j+10).ToString(),
                                Label = "Sub uv "+ (j+10).ToString(),
                                ChildrenRefUvs = null
                            }
                        }

                    };
                    block.RefUvs.Add(uv);
                }
               

                result.Add(block);
            }

            return result;
        }

    }
}
