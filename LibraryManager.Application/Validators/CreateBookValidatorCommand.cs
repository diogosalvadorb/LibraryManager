using FluentValidation;
using LibraryManager.Application.Commands.BookCommands.CreateBook;

namespace LibraryManager.Application.Validators
{
    public class CreateBookValidatorCommand : AbstractValidator<CreateBookCommand>
    {
        public CreateBookValidatorCommand()
        {
            RuleFor(x => x.Title)
               .NotEmpty().WithMessage("Title is required.")
               .MinimumLength(3).WithMessage("Title must be at least 3 characters long.")
               .MaximumLength(255).WithMessage("Title must not exceed 255 characters.");

            RuleFor(x => x.Author)
                .NotEmpty().WithMessage("Author is required.")
                .MinimumLength(3).WithMessage("Author name must be at least 3 characters long.")
                .MaximumLength(255).WithMessage("Author name must not exceed 255 characters.");

            RuleFor(x => x.Isbn)
                .NotEmpty().WithMessage("ISBN is required.")
                .Matches(@"^\d{13}$").WithMessage("ISBN must be a 13-digit number.");
        }
    }
}
