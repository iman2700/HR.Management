using Application.DTOs.LeaveType.validators;
using Application.Exceptions;
using Application.Features.LeaveType.Requests.Cammands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.LeaveType.Handlers.Cammands
{
    public class CreateLeaveTypeCommandHandelr : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private ILeaveTypeRepository _leaveTypeRepository;
        private IMapper _mapper;

        public CreateLeaveTypeCommandHandelr(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveTypeDtoValidator();
            var validatorResult= await validator.ValidateAsync(request.LeaveTypeDto);
            if (!validatorResult.IsValid) 
            {
                throw new ValidationException(validatorResult);
            }
            var leaveType =  _mapper.Map<Domain.LeaveType>(request.LeaveTypeDto);
            leaveType= await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
