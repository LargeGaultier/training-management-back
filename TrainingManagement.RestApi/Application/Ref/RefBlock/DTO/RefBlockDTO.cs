using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Application.Ref.RefBlock.DTO
{
    public class RefBlockDTO
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public long TrainingCenterId { get; set; }
        public List<RefDegreeDTO> RefDegreeDTO { get;set;}
        public List<RefUvDTO> RefUvDTO { get; set; }
        public long IdParentUv { get; set; }

        

        public static List<RefBlockDTO> GetMock(int id)
        {
            List<RefBlockDTO> result = new List<RefBlockDTO>();

            for (int i = 0; i < 10; i++)
            {
                RefBlockDTO block = new RefBlockDTO()
                {
                    Id = i,
                    RefDegreeDTO = new List<RefDegreeDTO>()
                    {
                        new RefDegreeDTO()
                        {
                            Id = 1,
                            Name = "Diiage Dev"
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

                block.RefUvDTO = new List<RefUvDTO>();

                for (int j = 0; j < 3; j++)
                {
                    RefUvDTO uv = new RefUvDTO()
                    {
                        Id = j,
                        Description = "description UvDev" + j,
                        Label = "UvDev" + j,
                        ChildRefUvDTO = new List<RefUvDTO>()
                        {
                            new RefUvDTO()
                            {
                                Id = j+10,
                                Description = "description sub uv " + (j+10).ToString(),
                                Label = "Sub uv "+ (j+10).ToString(),
                                ChildRefUvDTO = null
                            }
                        }

                    };
                    block.RefUvDTO.Add(uv);
                }
                if(i>3)
                {
                    if (i % 2 == 0)
                        block.IdParentUv = 1;
                    else
                        block.IdParentUv = 2;
                }

                result.Add(block);
            }

            return result;
        }

    }
}
