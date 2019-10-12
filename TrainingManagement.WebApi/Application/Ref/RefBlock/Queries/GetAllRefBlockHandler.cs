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
    public class GetAllRefBlockHandler : IRequestHandler<GetAllRefBlockQuery, List<RefBlockDTO>>
    {
        private readonly TrainingManagementRefDbContext _context;

        public GetAllRefBlockHandler(TrainingManagementRefDbContext context)
        {
            _context = context;
        }

        public Task<List<RefBlockDTO>> Handle(GetAllRefBlockQuery request, CancellationToken cancellationToken)
        {
            return _context.Ref_Block
                .Select(RefBlockDTO.Projection)
                .ToListAsync(cancellationToken);
        }
    }
}
