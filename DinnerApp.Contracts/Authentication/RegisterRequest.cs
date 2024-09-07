namespace DinnerApp.Contracts.Register;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password);