using System.ComponentModel.DataAnnotations;

namespace AuthService.Application.Contract.Roles.Commands
{
    public class ModifyRoleCommand
    {
        public int Id { get; set; }
        [Required]public string Title{ get; set; }
    }
}
