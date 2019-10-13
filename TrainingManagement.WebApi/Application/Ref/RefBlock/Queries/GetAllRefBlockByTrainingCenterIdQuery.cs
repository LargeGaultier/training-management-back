using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Application.Ref.DTO;

namespace TrainingManagement.WebApi.Application.Ref.TrainingCenter.Queries
{
    public class GetAllRefBlockByTrainingCenterIdQuery :  IRequest<List<RefBlockDTO>>
    {
        public long trainingCenterId { get; set; }
    }
}
