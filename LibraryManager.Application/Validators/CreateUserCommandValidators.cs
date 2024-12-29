using FluentValidation;
using LibraryManager.Application.Commands.UserCommands.CreateUser;

namespace LibraryManager.Application.Validators
{
    public class CreateUserCommandValidators : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidators()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full Name is required.")
                .MinimumLength(3).WithMessage("Full Name must be at least 3 characters long.")
                .MaximumLength(100).WithMessage("Full Name must not exceed 100 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(255).WithMessage("Email must not exceed 255 characters.");
        }
    }
}
