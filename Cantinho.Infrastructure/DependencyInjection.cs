using Cantinho.Application.Common.Interfaces.Authentication;
using Cantinho.Application.Common.Interfaces.Persistence;
using Cantinho.Application.Common.Interfaces.Services;
using Cantinho.Infrastructure.Authentication;
using Cantinho.Infrastructure.Persistence;
using Cantinho.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cantinho.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();
        
        return services; 
    }
}