using FluentValidation;
using System;

namespace Week15.Model
{
    public class PersonVvalidator : AbstractValidator<AddPerson>
    {
        public PersonVvalidator()
        {
            RuleFor(x => x.CreateDate)
                .LessThan(DateTime.UtcNow).WithMessage("CreateDate must not Be greater than today\n");
            RuleFor(x => x.Firstname)
                .NotEmpty().WithMessage("Name must not Be empty\n")
                .Length(0, 50).WithMessage("Length must less than 50 symbols\n");
            RuleFor(x => x.Lastname)
                .NotEmpty().WithMessage("Lastname must not Be empty\n")
                .Length(0, 50).WithMessage("Length must less than 50 symbols\n");
            RuleFor(x => x.JobPosition)
                .NotEmpty().WithMessage("JobPosition must not Be empty\n")
                .Length(0, 50).WithMessage("Length must less than 50 symbols\n");
            RuleFor(x => x.Salary)
                .InclusiveBetween(0, 10000).WithMessage("Sallary must be less than 10,000\n");
            RuleFor(x => x.WorkExperience)
                .NotEmpty().WithMessage("WorkExperience must not Be empty\n");
            RuleFor(x => x.PersonAddress.Country)
                .NotEmpty().WithMessage("Country must not Be empty\n");
            RuleFor(x => x.PersonAddress.City)
                .NotEmpty().WithMessage("City must not Be empty\n");
            RuleFor(x => x.PersonAddress.HomeNumber)
                .NotEmpty().WithMessage("HomeNumber must not Be empty\n");
        }
    }
}
