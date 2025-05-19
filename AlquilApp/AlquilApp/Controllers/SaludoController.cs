// Controllers/SaludoController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SaludoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hola desde el backend!");
    }
}
