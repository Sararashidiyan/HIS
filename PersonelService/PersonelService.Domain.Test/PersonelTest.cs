using PersonelService.Domain.Enums;
using PersonelService.Domain.Personels;
using System.Data;

namespace PersonelService.Domain.Test
{
    public class PersonelTest
    {
        [Fact]
        public void PersonelConstructor_ShouldCreatePersonelProperly()
        {
            // Arrange
            var firstName = "سارا";
            var lastName = "رشیدی یان";
            var address = "اکباتان";
            var fullName= $"{firstName} {lastName}";
            var gender = GenderEnum.Female;
            //Act
            var createdPersonel = new Personel(firstName, lastName, address, gender);
            //Assert
            Assert.Equal(fullName, createdPersonel.FullName);
            Assert.Equal(firstName, createdPersonel.FirstName);
            Assert.Equal(lastName, createdPersonel.LastName);
            Assert.Equal(address, createdPersonel.Address);
            Assert.Equal(gender, createdPersonel.Gender);
        }
        [Fact]
        public void Update_ShouldUpdatePersonelProperly()
        {
            // Arrange
            var firstName = "سارا";
            var lastName = "رشیدی یان";
            var address = "اکباتان";
            var fullName = $"{firstName} {lastName}";
            var gender = GenderEnum.Female;
            var createdPersonel = new Personel(firstName, lastName, address, gender);
            var newFirstName = "1سارا";
            var newLastName = "رشیدی یان1";
            var newAddress = "اکباتان1";
            var newFullName = $"{newFirstName} {newLastName}";
            var newGender = GenderEnum.Male;

            //Act
            createdPersonel.Update(firstName, lastName, address, gender);
            //Assert
            Assert.Equal(newFullName, createdPersonel.FullName);
            Assert.Equal(newFirstName, createdPersonel.FirstName);
            Assert.Equal(newLastName, createdPersonel.LastName);
            Assert.Equal(newAddress, createdPersonel.Address);
            Assert.Equal(newGender, createdPersonel.Gender);
        }
      
    }
}
