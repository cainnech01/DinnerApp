using DinnerApp.Domain.Entities;

namespace DinnerApp.Application.Services.Auth;

public record AuthResult(
    User User,
    string Token);