using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.JwtTokenGenerator
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(string clientId);
        string ReferehToken();
    }
}
