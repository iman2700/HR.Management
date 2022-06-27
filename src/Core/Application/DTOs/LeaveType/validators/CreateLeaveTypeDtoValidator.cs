using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.LeaveType.validators
{
    public class CreateLeaveTypeDtoValidator:AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator() 
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{peropertyName} is required")
                .NotNull().MaximumLength(40).WithMessage("{peropertyName} must exceed 40 characters");

            RuleFor(p => p.DefaultDays).NotEmpty().WithMessage("{peropertyName} is required")
               .GreaterThan(0).LessThan(100);
        }
        
    }
}
