using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[animales]")]
public class AnimalController : ControllerBase
{
    [HttpGet]
    [Route("listar")]
    public dynamic listar()
    {
        
    }
    
    [HttpPost]
    [Route("guardar")]
    public dynamic guardar()
    {
        
    }
}