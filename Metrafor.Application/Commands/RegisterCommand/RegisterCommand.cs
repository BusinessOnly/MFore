namespace Metrafor.Application.Commands.RegisterCommand
{
    public partial class RegisterCommand
    {
        private readonly IUserRepository _userRepository;

        public RegisterCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
