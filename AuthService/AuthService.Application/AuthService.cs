using AuthService.Application.Contract;
using AuthService.Application.Contract.Auth;
using AuthService.Domain.Exceptions;
using AuthService.Domain.JwtTokenGenerator;
using Company.SharedKernel;
using Microsoft.Extensions.Options;
using System;

namespace AuthService.Application
{
    public class AuthService(IOptions<JwtSettings> _setting, IJwtTokenGenerator _jwtTokenGenerator, IRefreshTokenStore _refreshTokenStore) : IAuthService
    {
        public Task<AuthResponse> Authenticate(AuthRequest authRequest)
        {
            //if (authRequest.ClientId != _setting.ClientId || authRequest.ClientSecret != _setting.ClientSecret)
            //    throw new UnAuthorizedException();
            return GenerateToken(authRequest.ClientId);
        }

        public Task<AuthResponse> RefreshToken(RefreshTokenRequest request)
        {
            if (!_refreshTokenStore.IsValid(request.RefreshToken))
                throw new UnAuthorizedException();
            else
                return GenerateToken(request.ClientId);
        }

        private Task<AuthResponse> GenerateToken(string clientId)
        {
            var newAccessToken = _jwtTokenGenerator.GenerateToken(clientId);
            var newRefreshToken = Guid.NewGuid().ToString();
            _refreshTokenStore.Save(clientId, newRefreshToken, DateTime.UtcNow.AddDays(7));
            return Task.FromResult<AuthResponse>(new AuthResponse()
            {
                RefreshToken = newRefreshToken,
                AccessToken = newAccessToken,
            });
        }
    }
}
