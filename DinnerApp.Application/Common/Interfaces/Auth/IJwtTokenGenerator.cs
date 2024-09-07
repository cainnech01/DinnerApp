using DinnerApp.Domain.Entities;

namespace DinnerApp.Application.Common.Interfaces.Auth;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}