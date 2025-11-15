using System.Data;
using AuthService.Domain.Roles;

namespace AuthService.Domain.Test
{
    public class RoleTest
    {
        [Fact]
        public void RoleConstructor_ShouldCreateRoleProperly()
        {
            // Arrange
            var roleName = "Admin";
            //Act
            var createdRole=new Role(roleName);
            //Assert
            Assert.Equal(roleName, createdRole.Title);
            Assert.True(createdRole.IsActive);
        }
        [Fact]
        public void Update_ShouldUpdateRoleProperly()
        {
            // Arrange
            var oldRole = "Admin";
            var createdRole = new Role(oldRole);
            var newRole = "User";
            //Act
            createdRole.Update(newRole);
            //Assert
            Assert.Equal(newRole, createdRole.Title);
        }
        [Fact]
        public void Deactivate_ShouldDeactiveRoleProperly()
        {
            // Arrange
            var roleName = "Admin";
            var createdRole = new Role(roleName);
            //Act
            createdRole.Deactivate();
            //Assert
            Assert.False(createdRole.IsActive);
        }
        [Fact]
        public void Activate_ShouldActiveRoleProperly()
        {
            // Arrange
            var roleName = "Admin";
            var createdRole = new Role(roleName);
            createdRole.Deactivate();
            //Act
            createdRole.Activate();
            //Assert
            Assert.True(createdRole.IsActive);
        }
    }
}