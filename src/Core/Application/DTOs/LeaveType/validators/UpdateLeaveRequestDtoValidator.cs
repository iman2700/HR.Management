using Application.DTOs.LeaveRequest;
using Application.DTOs.LeaveRequest.Validators;
using Application.Persistence.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.LeaveType.validators
{
    public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveRequestDtoValidator(_leaveTypeRepository));

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
