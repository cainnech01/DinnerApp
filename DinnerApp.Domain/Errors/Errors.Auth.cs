using ErrorOr;

namespace DinnerApp.Domain.Errors;

public static partial class Errors
{
    public static class Auth
    {
        public static Error InvalidCredentials => Error.Validation(
            code: "auth.invalid",
            description: "Invalid credentials"
        );
    }
}