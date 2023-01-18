namespace Metrafor.Domain.Entries
{
    public sealed class User
    {
        public User() { }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public Guid UserId { get; set; }
        public string Login { get; private set; } = null!;
        public string Password { get; private set; } = null!;
    }
}
