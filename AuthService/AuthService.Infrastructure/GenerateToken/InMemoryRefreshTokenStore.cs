using AuthService.Domain.JwtTokenGenerator;

namespace AuthService.Infrastructure.GenerateToken
{
    public class InMemoryRefreshTokenStore : IRefreshTokenStore
    {
        private readonly Dictionary<string, (string ClientId, DateTime ExpiresAt)> _store = new();

        public bool IsValid(string refreshToken)
        {
            if (_store.TryGetValue(refreshToken, out var entry))
                return entry.ExpiresAt > DateTime.UtcNow;
            return false;
        }

        public void Save(string clientId, string refreshToken, DateTime expiresAt)
        {
            _store[refreshToken] = (clientId, expiresAt);
        }

        public void Revoke(string refreshToken)
        {
            _store.Remove(refreshToken);
        }
    }
}
