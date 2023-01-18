namespace Metrafor.Domain.Entries
{
    public sealed class Person
    {
        public Person() { }

        public Person(Guid personId, string lastName, string firstName, string patronymic, string inn,
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
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string Inn { get; set; } = null!;
        public string PassportSeries { get; set; } = null!;
        public string PassportNumber { get; set; } = null!;
        public string PassportWho { get; set; } = null!;
        public string PassportWhen { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string AddressCity { get; set; } = null!;
        public string AddressStreet { get; set; } = null!;
        public string AddressHouse { get; set; } = null!;
        public string Position { get; set; } = null!;
    }
}
