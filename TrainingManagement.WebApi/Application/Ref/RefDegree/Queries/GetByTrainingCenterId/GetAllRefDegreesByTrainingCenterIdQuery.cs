using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingManagement.WebApi.Application.Ref.DTO;

namespace TrainingManagement.WebApi.Application.Ref.RefDegree.Queries.GetByTrainingCenterId
{
    public class GetAllRefDegreesByTrainingCenterIdQuery : IRequest<List<RefDegreeDTO>>
    {
        public long trainingCenterId { get; set; }
    }
}
