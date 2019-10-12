using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Application.Ref.RefBlock.DTO

{
    public class RefUvDTO
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public List<RefUvDTO> ChildrenRefUvDTOs { get; set; }
    }
}
