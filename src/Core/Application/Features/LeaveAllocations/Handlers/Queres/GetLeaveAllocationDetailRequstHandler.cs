using Application.DTOs.LeaveAllocation;
using Application.Features.LeaveAllocations.Requests.Queres;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.LeaveAllocations.Handlers.Queres
{
    public class GetLeaveAllocationDetailRequstHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
    {
        private ILeaveAllocationRepository _leaveAllocationRepository;
        private IMapper _mapper;

        public GetLeaveAllocationDetailRequstHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveAllocationDto> (leaveAllocation);
        }
    }
}
