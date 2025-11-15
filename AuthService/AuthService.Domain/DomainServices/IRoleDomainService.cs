using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.SharedKernel;

namespace AuthService.Domain.DomainServices
{
    public interface IRoleDomainService:IDomainService
    {
        Task<bool> IsRoleTitleUnique(string title,int? id=null);
        Task<bool> IsRoleHasPermission(int roleId);
    }
}
