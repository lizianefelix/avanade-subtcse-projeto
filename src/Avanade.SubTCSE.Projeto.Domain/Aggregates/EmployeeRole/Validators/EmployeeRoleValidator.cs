using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () => 
            {
                RuleFor(employee => employee.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
            });
        }
    }
}
