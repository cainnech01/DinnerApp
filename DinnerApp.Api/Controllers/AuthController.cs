using DinnerApp.Application.Services.Auth;
using DinnerApp.Contracts.Auth;
using DinnerApp.Contracts.Login;
using DinnerApp.Contracts.Register;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace DinnerApp.Api.Controllers;


[Route("auth")]
public class AuthController : ApiController 
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        ErrorOr<AuthResult> authResult = _authService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password    
        );

        return authResult.Match(
            authResult => Ok(MapRequest(authResult)),
            errors => Problem(errors)
        );
    }


    private static AuthResponse MapRequest(AuthResult authResult)
    {
        return new AuthResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
        );
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authService.Login(
            request.Email,
            request.Password    
        );

        return authResult.Match(
            authResult => Ok(MapRequest(authResult)),
            errors => Problem(errors)  
        );
    }
}