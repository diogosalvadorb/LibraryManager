using MediatR;

namespace LibraryManager.Application.Commands.UserCommands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public CreateUserCommand(string name, string email)
        {
            FullName = name;
            Email = email;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
    }
}
