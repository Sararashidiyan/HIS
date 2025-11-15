using Company.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Application.Contract.Auth
{
    public interface IAuthService : IApplicationService
    {
        Task<AuthResponse> Authenticate(AuthRequest authCMD);
        Task<AuthResponse> RefreshToken(RefreshTokenRequest request);
    }
}
