using Microsoft.AspNetCore.Mvc;

namespace TodoAzure.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Teste : ControllerBase
{

    private readonly IConfiguration _configuration;

    public Teste(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("con-string")]
    public IActionResult GetConnectionString() =>
        Ok(_configuration.GetConnectionString("ConString"));

    [HttpGet("ambiente")]
    public IActionResult GetAmbiente() =>
    Ok(_configuration.GetSection("Ambiente").Value);

}
