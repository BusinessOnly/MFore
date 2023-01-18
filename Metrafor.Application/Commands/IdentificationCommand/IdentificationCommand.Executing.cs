using Metrafor.Domain.Entries;

namespace Metrafor.Application.Commands.IdentificationCommand
{
    public partial class IdentificationCommand
    {
        public async Task<Result> ExecuteAsync(Request request)
        {
            try
            {
                var person = await _personRepository.FindAsync(request.PersonId);
                if (person != null)
                    return new Result { DisplayMessage = "Пользователь уже был инициализирован." };

                person = new Person(request.PersonId,
                    request.LastName, request.FirstName, request.Patronymic, request.Inn, 
                    request.PassportSeries, request.PassportNumber, request.PassportWho, request.PassportWhen, 
                    request.Phone, request.AddressCity, request.AddressStreet, request.AddressHouse, request.Position);
                await _personRepository.SaveAsync(person);

                return new Result { Success = true };
            }
            catch (Exception ex)
            {
                return new Result { DisplayMessage = ex.Message };
            }
        }
    }
}
