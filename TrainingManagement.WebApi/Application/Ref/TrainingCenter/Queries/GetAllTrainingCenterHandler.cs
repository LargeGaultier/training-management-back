using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrainingManagement.WebApi.Application.Ref.TrainingCenter.Models;
using TrainingManagement.WebApi.Persistence;

namespace TrainingManagement.WebApi.Application.Ref.TrainingCenter.Queries
{
    public class GetAllTrainingCenterHandler : IRequestHandler<GetAllTrainingCenterQuery, List<Models.TrainingCenterDTO>>
    {
        private readonly TrainingManagementRefDbContext _context;

        public GetAllTrainingCenterHandler(TrainingManagementRefDbContext context)
        {
            _context = context;
        }

        public Task<List<Models.TrainingCenterDTO>> Handle(GetAllTrainingCenterQuery request, CancellationToken cancellationToken)
        {
            return _context.Ref_TrainingCenter
                .Select(Models.TrainingCenterDTO.Projection)
                .ToListAsync(cancellationToken);
        }
    }
}
