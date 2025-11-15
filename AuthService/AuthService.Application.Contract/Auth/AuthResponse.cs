using System.Text.Json.Serialization;

namespace AuthService.Application.Contract.Auth
{
    public class AuthResponse
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
