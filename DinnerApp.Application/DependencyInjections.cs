using DinnerApp.Application.Services.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerApp.Application;

public static class DependencyInjections
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();

        return services;
    }   
}