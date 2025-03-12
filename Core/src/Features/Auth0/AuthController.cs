﻿using Core.src.Features.User;
using Core.src.Shared.Common;
using Core.src.Shared.ResultPattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core.src.Features.Auth0;

[ApiController]
[Route("api/auth")]
public class AuthController(ILogger<AuthController> logger, IAuthService _authService, IUserRepository _userRepository) : ControllerBase
{
    // Summary:
    //     This endpoint is only used for testing if the token is parsed correctly.
    //
    // Remarks:
    //     Remove when development is finished.
    [HttpPost("authenticate")]
    [Authorize]
    public IActionResult Authenticate()
    {
        try
        {
            var userId = TokenExtractor.GetAuth0UserId(User);
            return Ok($"Valid token for user: {userId}");
        }
        catch (Exception e)
        {
            logger.LogError(e, "Auth0AccessToken");
            throw;
        }
    }

    // Summary:
    //     This endpoint should not be used after testing.
    //     Call Auth0 servers directly from frontend instead.
    //
    // Remarks:
    //     Store values in a safe place. Delete service method when finsihed.
    [HttpPost("refresh-token")]
    [AllowAnonymous]
    public async Task<IActionResult> RefreshToken([FromBody] string refreshToken)
    {
        try
        {
            var result = await _authService.RefreshAccessToken(refreshToken);
            return result.Resolve(suc => Ok(suc.Data),
                err => BadRequest(err.Message));
        }
        catch (Exception e)
        {
            logger.LogError(e, "Refresh token");
            return StatusCode(500, "Something went wrong.");
        }
    }

    // Summary:
    //     This endpoint should not be used after testing.
    //     Call Auth0 servers directly from frontend instead.
    //
    // Remarks:
    //     Store values in a safe place.
    //     Do NOT delete the service method.
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<ActionResult<Auth0LoginResponse>> Login(AuthRequest request)
    {
        try
        {
            var result = await _authService.Login(request);
            return result.Resolve(suc => Ok(suc.Data),
                err => BadRequest(err.Message));
        }
        catch (Exception e)
        {
            logger.LogError(e, "Login");
            return StatusCode(500, "Something went wrong.");
        }
    }

    // Summary:
    //     This endpoint creates a new user in auth0 database for authentication,
    //     and stores in this servers database for handling relations internally.
    //
    // Remarks:
    //     Use the user objects Id, not the Auth0 id when creating relations.
    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] AuthRequest request)
    {
        try
        {
            var registerResult = await _authService.Register(request);
            if (registerResult.IsError)
            {
                return BadRequest(registerResult.Message);
            }

            var auth0Response = registerResult.Data;
            var userEntity = new UserEntity()
            {
                Email = request.Email,
                Auth0Id = auth0Response.Id,
            };

            var userResult = await _userRepository.Create(userEntity);
            if (userResult.IsError)
            {
                logger.LogError(userResult.Message);
                return BadRequest(userResult.Message);
            }

            var loginResult = await _authService.Login(request);
            return loginResult.Resolve(suc => Ok(suc.Data),
                err => BadRequest(err.Message));
        }
        catch (Exception e)
        {
            logger.LogError(e, "Register");
            return StatusCode(500, "Something went wrong.");
        }
    }
}