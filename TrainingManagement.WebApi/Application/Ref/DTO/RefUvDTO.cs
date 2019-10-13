using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Application.Ref.DTO

{
    public class RefUvDTO
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public List<RefUvDTO> ChildrenRefUvDTOs { get; set; }


        public static RefUvDTO ToDTO(Ref_Uv t)
        {
            var result = new RefUvDTO
            {
                Id = t.Id,
                Label = t.Label,
                Description = t.Description
            };
            result.ChildrenRefUvDTOs.AddRange(t.Ref_Uvs.Select(e => RefUvDTO.ToDTO(e)));
            return result;
        }
        public static Expression<Func<Ref_Uv, RefUvDTO>> Projection
        {
            get
            {
                return t => new RefUvDTO
                {
                    Id = t.Id,
                    Label = t.Label,
                    Description = t.Description,
                    ChildrenRefUvDTOs = t.Ref_Uvs.Select(e=>RefUvDTO.ToDTO(e)).ToList()
                };
            }
        }
    }
}
