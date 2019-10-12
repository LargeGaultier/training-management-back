using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TrainingManagement.WebApi.Domain.Ref;

namespace TrainingManagement.WebApi.Application.Ref.TrainingCenter.Models
{
    public class TrainingCenterDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public static Expression<Func<Ref_TrainingCenter, TrainingCenterDTO>> Projection
        {
            get
            {
                return t => new TrainingCenterDTO
                {
                    Name = t.Name,
                    Id = t.Id
                };
            }
        }
    }
}
