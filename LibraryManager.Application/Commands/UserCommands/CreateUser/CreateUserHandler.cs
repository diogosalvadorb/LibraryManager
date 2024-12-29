using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Commands.UserCommands.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _repository;
        public CreateUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Email);

            await _repository.AddAsync(user);

            return user.Id;
        }
    }
}
