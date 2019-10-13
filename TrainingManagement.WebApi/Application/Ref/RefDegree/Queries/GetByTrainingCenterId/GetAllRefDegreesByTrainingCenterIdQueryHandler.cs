using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TrainingManagement.WebApi.Application.Ref.DTO;
using TrainingManagement.WebApi.Persistence;

namespace TrainingManagement.WebApi.Application.Ref.RefDegree.Queries.GetByTrainingCenterId
{
    public class GetAllRefDegreesByTrainingCenterIdQueryHandler : IRequestHandler<GetAllRefDegreesByTrainingCenterIdQuery, List<RefDegreeDTO>>
    {
        TrainingManagementRefDbContext _context;
        public GetAllRefDegreesByTrainingCenterIdQueryHandler(TrainingManagementRefDbContext context)
        {
            _context = context;
        }
        public Task<List<RefDegreeDTO>> Handle(GetAllRefDegreesByTrainingCenterIdQuery request, CancellationToken cancellationToken)
        {
            return _context.Ref_Degree
                 .Where(e => e.Ref_TrainingCenterId == request.trainingCenterId)
                 .Select(e => RefDegreeDTO.ToDTO(e))
                 .ToListAsync(cancellationToken);
        }
    }
}
