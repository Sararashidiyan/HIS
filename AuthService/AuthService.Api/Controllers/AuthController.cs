using AuthService.Application.Contract;
using AuthService.Application.Contract.Auth;
using Company.SharedKernel.Http;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using YourProject.Grpc;

namespace AuthService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService _authService) : Auth.AuthBase
    {


        //public override Task<TokenResponse> GenerateToken(TokenRequest request, ServerCallContext context)
        //{
        //    var token =  _authService.Authenticate(request);
        //    return Task.FromResult(new TokenResponse { AccessToken = token });
        //}

       
        //[HttpPost("refresh-token")]
        //public Task<IActionResult> Post(RefreshTokenRequest request)
        //{
        //    var token = _authService.RefreshToken(request);
        //    return Task.FromResult(new TokenResponse { AccessToken = token });
        //}
    }
}
