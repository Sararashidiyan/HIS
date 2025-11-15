using AuthService.Application.Contract.Roles.Commands;
using AuthService.Application.Contract.Roles.Dtos;

namespace AuthService.Application.Contract.Roles
{
    public interface IRoleService
    {
        Task<List<RoleDto>> GetAll();
        Task<RoleDto> GetById(int id);
        Task Add(AddRoleCommand command);
        Task Modify(ModifyRoleCommand command);
        Task Activate(int id);
        Task Deactivate(int id);
        Task Delete(int id);
    }
}
