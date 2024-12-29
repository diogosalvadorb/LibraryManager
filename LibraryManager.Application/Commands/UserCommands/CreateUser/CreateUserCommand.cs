using MediatR;

namespace LibraryManager.Application.Commands.UserCommands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public CreateUserCommand(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
