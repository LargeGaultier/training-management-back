using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.WebApi.Application.Ref.RefBlock.DTO;

namespace TrainingManagement.WebApi.Application.Ref.TrainingCenter.Queries
{
    public class GetAllRefBlockQuery :  IRequest<List<RefBlockDTO>>
    {
    }
}
