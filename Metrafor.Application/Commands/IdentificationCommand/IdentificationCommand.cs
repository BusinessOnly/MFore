namespace Metrafor.Application.Commands.IdentificationCommand
{
    public partial class IdentificationCommand
    {
        private readonly IPersonRepository _personRepository;

        public IdentificationCommand(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
    }
}
