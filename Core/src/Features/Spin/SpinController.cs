using Microsoft.AspNetCore.Mvc;

namespace Core.src.Features.Spin;

[ApiController]
[Route("api/[controller]")]
public class SpinController(ISpinGameManager spinGameManager) : ControllerBase
{
    [HttpGet]
    public IActionResult Test()
    {
        spinGameManager.Test();

        return Ok("Test OK!");
    }
}