using AuthService.Application.Contract.Auth;
using Grpc.Core;

namespace AuthService.Api.Controllers
{
    public class GRPCAuthService(IAuthService _authService) //: Auth.AuthBase
    {
        //public override Task<GrpcTokenResponse> GenerateToken(GrpcTokenRequest request, ServerCallContext context)
        //{
        //    var token = _authService.Authenticate(request);
        //    return Task.FromResult(new GrpcTokenResponse { AccessToken = token });
        //}


        //[HttpPost("refresh-token")]
        //public Task<IActionResult> Post(RefreshTokenRequest request)
        //{
        //    var token = _authService.RefreshToken(request);
        //    return Task.FromResult(new TokenResponse { AccessToken = token });
        //}
    }
}
