namespace AuthService.Application.Contract.Roles.Commands
{
    public class ModifyRoleCommand
    {
        public int Id { get; set; }
        public string Title{ get; set; }
    }
}
