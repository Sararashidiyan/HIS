using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.SharedKernel;

namespace AuthService.Domain.Roles
{
    public interface IRoleQueryRepository: IQueryRepository<int,Role>
    {
    }
    public interface IRoleCommandRepository : ICommandRepository<int, Role>
    {
    }
}
