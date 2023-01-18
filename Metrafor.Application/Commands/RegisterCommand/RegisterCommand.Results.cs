namespace Metrafor.Application.Commands.RegisterCommand
{
    public partial class RegisterCommand
    {
        public class Result : BaseCommandResult
        {
            public Guid UserId { get; set; }
        }
    }
}
