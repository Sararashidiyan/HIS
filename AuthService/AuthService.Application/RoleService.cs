using AuthService.Application.Contract.Roles;
using AuthService.Application.Contract.Roles.Commands;
using AuthService.Application.Contract.Roles.Dtos;
using AuthService.Application.Mappers;
using AuthService.Domain.DomainServices;
using AuthService.Domain.Roles;

namespace AuthService.Application
{
    public class RoleService(IRoleRepository _repository,IRoleDomainService _domainService) : IRoleService
    {
        private async Task CheckIfRoleHasPermission(int id)
        {
            if (await _domainService.IsRoleHasPermission(id))
                throw new Exception();
        }
        private void GuardAgainstNullVale(Role role)
        {
            if (role == null)
                throw new  DirectoryNotFoundException(); 
        }
        private async Task CheckIfRoleTitleIsDuplicate(string title,int? id=null)
        {
            if (await _domainService.IsRoleTitleUnique(title, id))
                throw new Exception();
        }

        public async Task Activate(int id)
        {
           var selectedRole=await _repository.GetByIdAsync(id);
            GuardAgainstNullVale(selectedRole);
            selectedRole.Activate();
        }

        public async Task Add(AddRoleCommand command)
        {
           await CheckIfRoleTitleIsDuplicate(command.Title);
            var roleToBeCreate=new Role(command.Title);
            await _repository.CreateAsync(roleToBeCreate);
        }

      
        public async Task Deactivate(int id)
        {
            var selectedRole = await _repository.GetByIdAsync(id);
            GuardAgainstNullVale(selectedRole);
            selectedRole.Deactivate();
        }

        public async Task Delete(int id)
        {
            await CheckIfRoleHasPermission(id);
            var selectedRole = await _repository.GetByIdAsync(id);
            GuardAgainstNullVale(selectedRole);
            await _repository.DeleteAsync(selectedRole);
        }
        public async Task<List<RoleDto>> GetAll()
        {
            var roles = await _repository.GetAllAsync();
            return RoleMappers.Map(roles);
        }

        public async Task<RoleDto> GetById(int id)
        {
            var selectedRole = await _repository.GetByIdAsync(id);
            GuardAgainstNullVale(selectedRole);
            return RoleMappers.Map(selectedRole);
        }
        public async Task Modify(ModifyRoleCommand command)
        {
            await CheckIfRoleTitleIsDuplicate(command.Title,command.Id);
            await CheckIfRoleHasPermission(command.Id);
            var selectedRole = await _repository.GetByIdAsync(command.Id);
            GuardAgainstNullVale(selectedRole);
            selectedRole.Update(command.Title);
        }
    }
}
