using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.RestApi.Application.Ref.TrainingCenter.Queries
{
    public class GetAllTrainingCenterQuery :  IRequest<List<Models.TrainingCenterDTO>>
    {
    }
}
