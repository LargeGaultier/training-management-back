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
        public List<RefDegreeDTO> RefDegreeDTOs { get;set;}
        public List<RefUvDTO> RefUvDTOs { get; set; }
       

        

        public static List<RefBlockDTO> GetMock(long id)
        {
            
            List<RefBlockDTO> result = new List<RefBlockDTO>();

            for (int i = 0; i < 10; i++)
            {
                RefBlockDTO block = new RefBlockDTO()
                {
                    Id = i,
                    RefDegreeDTOs = new List<RefDegreeDTO>()
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

                block.RefUvDTOs = new List<RefUvDTO>();

                for (int j = 0; j < 3; j++)
                {
                    RefUvDTO uv = new RefUvDTO()
                    {
                        Id = j,
                        Description = "description UvDev" + j,
                        Label = "UvDev" + j,
                        ChildrenRefUvDTOs = new List<RefUvDTO>()
                        {
                            new RefUvDTO()
                            {
                                Id = j+10,
                                Description = "description sub uv " + (j+10).ToString(),
                                Label = "Sub uv "+ (j+10).ToString(),
                                ChildrenRefUvDTOs = null
                            }
                        }

                    };
                    block.RefUvDTOs.Add(uv);
                }
               

                result.Add(block);
            }

            return result;
        }

    }
}
