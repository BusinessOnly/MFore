namespace Metrafor.Application.Commands.IdentificationCommand
{
    public partial class IdentificationCommand
    {
        public class Request
        {
            public Request(Guid personId, string lastName, string firstName, string patronymic, string inn,
                string passportSeries, string passportNumber, string passportWho, string passportWhen,
                string phone, string addressCity, string addressStreet, string addressHouse, string position)
            {
                PersonId = personId;

                LastName = lastName;
                FirstName = firstName;
                Patronymic = patronymic;
                Inn = inn;

                PassportSeries = passportSeries;
                PassportNumber = passportNumber;
                PassportWho = passportWho;
                PassportWhen = passportWhen;

                Phone = phone;
                AddressCity = addressCity;
                AddressStreet = addressStreet;
                AddressHouse = addressHouse;
                Position = position;
            }

            public Guid PersonId { get; set; }

            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Patronymic { get; set; }
            public string Inn { get; set; }

            public string PassportSeries { get; set; }
            public string PassportNumber { get; set; }
            public string PassportWho { get; set; }
            public string PassportWhen { get; set; }

            public string Phone { get; set; }
            public string AddressCity { get; set; }
            public string AddressStreet { get; set; }
            public string AddressHouse { get; set; }
            public string Position { get; set; }
        }
    }
}
