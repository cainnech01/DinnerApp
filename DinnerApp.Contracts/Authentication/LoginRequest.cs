namespace DinnerApp.Contracts.Login;

public record LoginRequest(
    string Email,
    string Password);