namespace Metrafor.Application.Commands.RegisterCommand
{
    public partial class RegisterCommand
    {
        public class Request
        {
            public Request(string login, string password)
            {
                Login = login;
                Password = password;
            }

            public string Login { get; set; }
            public string Password { get; set; }
        }
    }
}
