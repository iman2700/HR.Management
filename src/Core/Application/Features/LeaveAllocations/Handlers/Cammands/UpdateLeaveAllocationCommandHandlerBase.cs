using Application.Persistence.Contracts;
using AutoMapper;

namespace Application.Features.LeaveAllocations.Handlers.Cammands
{
    public class UpdateLeaveAllocationCommandHandlerBase
    {
        private ILeaveAllocationRepository _leaveAllocationRepository;
        private IMapper _mapper;
    }
}