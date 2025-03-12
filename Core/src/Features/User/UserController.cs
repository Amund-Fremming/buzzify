using Core.src.Shared.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace Core.src.Features.User;

[ApiController]
[Route("api/[controller]")]
public class UserController(ILogger<UserController> logger, IUserRepository repository) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var result = await repository.GetById(id);
            return result.Resolve(suc => Ok(result.Data),
                err => BadRequest(result.Message));
        }
        catch (Exception e)
        {
            logger.LogError(e, "GetBydId");
            return StatusCode(500, "Internal server error.");
        }
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await repository.GetAll();
            return result.Resolve(suc => Ok(suc.Data),
                err => BadRequest(result.Message));
        }
        catch (Exception e)
        {
            logger.LogError(e, "GetAll");
            return StatusCode(500, "Internal server error.");
        }
    }
}