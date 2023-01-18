using Metrafor.Application;
using Metrafor.Application.Commands.IdentificationCommand;
using Metrafor.Application.Commands.RegisterCommand;
using Microsoft.AspNetCore.SignalR;

namespace Metrafor.Api.Hubs
{
    public class IdentityHub : Hub
    {
        private readonly IUserRepository _userRepository;
        private readonly IPersonRepository _personRepository;

        public IdentityHub(IUserRepository userRepository, IPersonRepository personRepository) 
        {
            _userRepository = userRepository;
            _personRepository = personRepository;
        }

        public async Task Register(RegisterCommand.Request request)
        {
            var registryCommand = new RegisterCommand( _userRepository);
            var result = await registryCommand.ExecuteAsync(request);

            await Clients.Caller.SendAsync("RegisterReceive", result);
        }

        public async Task Identification(IdentificationCommand.Request request)
        {
            var identificationCommand = new IdentificationCommand(_personRepository);
            var result = await identificationCommand.ExecuteAsync(request);

            await Clients.Caller.SendAsync("IdentificationReceive", result);
        }
    }
}
