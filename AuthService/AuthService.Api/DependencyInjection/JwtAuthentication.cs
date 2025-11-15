using Company.SharedKernel;

namespace AuthService.Api.DependencyInjection
{
    public static class JwtAuthentication
    {
        public static IServiceCollection AddUserAuthentication(this IServiceCollection services,IConfiguration _configuration) {
            var jwtSettings = new JwtSettings() 
            { 
                Key = _configuration["Jwt:Key"],
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
            };
            services.AddJwtAuthentication(jwtSettings);
            return services;
        }
    }
}
