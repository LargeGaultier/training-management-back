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
using TrainingManagement.WebApi.Application.Ref.RefBlock.DTO;

namespace TrainingManagement.WebApi.Application.Ref.TrainingCenter.Queries
{
    public class GetAllRefBlockByTrainingCenterIdHandler : IRequestHandler<GetAllRefBlockByTrainingCenterIdQuery, List<RefBlockDTO>>
    {
        private readonly TrainingManagementRefDbContext _context;

        public GetAllRefBlockByTrainingCenterIdHandler(TrainingManagementRefDbContext context)
        {
            _context = context;
        }

        public Task<List<RefBlockDTO>> Handle(GetAllRefBlockByTrainingCenterIdQuery request, CancellationToken cancellationToken)
        {
            return _context.Ref_Block
                .Where(e => e.Ref_TrainingCenterId == request.trainingCenterId)
                .Include(e => e.Ref_Uvs)
                .Include(e => e.Ref_DegreeBlocks).ThenInclude(f => f.Ref_Degree)
                .Select(e=>RefBlockDTO.ToDTO(e))
                .ToListAsync(cancellationToken);
        }
    }
}
