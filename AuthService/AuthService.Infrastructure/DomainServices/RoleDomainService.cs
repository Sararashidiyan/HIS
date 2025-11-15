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
        public bool IsCurrentRoleHasPermission(int roleId)
        {
            throw new NotImplementedException();
        }

        public bool IsRoleTitleUnique(string title)
        {
            throw new NotImplementedException();
        }
    }
}
