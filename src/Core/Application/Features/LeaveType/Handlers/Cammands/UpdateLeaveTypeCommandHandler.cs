using Application.DTOs.LeaveType;
using Application.Features.LeaveType.Requests.Cammands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.LeaveType.Handlers.Cammands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private ILeaveTypeRepository _leaveTypeRepository;
        private IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
              var leaveType = await _leaveTypeRepository.Get(request.LeaveTypeDto.Id);
             _mapper.Map(request.LeaveTypeDto, leaveType);
             await _leaveTypeRepository.Update(leaveType);
             return Unit.Value;
        }
        
    }
}
