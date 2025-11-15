using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthService.Domain.DomainServices;

namespace AuthService.Infrastructure.DomainServices
{
    public class RoleDomainService : IRoleDomainService
    {
       
        public Task<bool> IsRoleHasPermission(int roleId)
        {
            throw new NotImplementedException();
        }

        public bool IsRoleTitleUnique(string title)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsRoleTitleUnique(string title, int? id = null)
        {
            throw new NotImplementedException();
        }
    }
}
