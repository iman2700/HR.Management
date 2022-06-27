using Application.Exceptions;
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
    public class DeleteLeaveTypeCommandHandler:IRequestHandler<DeleteLeaveTypeCommand>
    {
        private readonly IMapper _mapper;
        ILeaveTypeRepository _leaveRepository;

        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
           var leaveType= await _leaveRepository.Get(request.Id);
            if (leaveType == null)
            throw new NotFoundException(nameof(Domain.LeaveType),request.Id);

            await _leaveRepository.Delete(leaveType);
        }
    }
}
