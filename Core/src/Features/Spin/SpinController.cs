using Microsoft.AspNetCore.Mvc;

namespace Core.src.Features.Spin;

[ApiController]
[Route("api/[controller]")]
public class SpinController(ISpinGameManager spinGameManager) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Test()
    {
        await spinGameManager.Test();

        return Ok("Test OK!");
    }
}