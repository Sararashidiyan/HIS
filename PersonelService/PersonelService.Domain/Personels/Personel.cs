using Company.SharedKernel;
using PersonelService.Domain.Enums;

namespace PersonelService.Domain.Personels
{
    public class Personel : AuditableEntityBase<long>, IAggrigateRoot
    {
        public Personel(string firstName, string lastName, string address, GenderEnum gender)
        {
            SetProperties(firstName, lastName, address, gender);
        }

        private void SetProperties(string firstName, string lastName, string address, GenderEnum gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Gender = gender;
        }

        public void Update(string firstName,string lastName,string address, GenderEnum gender)
        {
            SetProperties(firstName, lastName, address, gender);

        }
        public string FullName => $"{FirstName} {LastName}";
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public GenderEnum Gender { get; private set; }
    }
}
