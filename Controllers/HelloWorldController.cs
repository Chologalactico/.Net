using Microsoft.AspNetCore.Mvc;
namespace Api.net.Controllers;

[ApiController]
[Route("api/[controller]")] //Ruta general de todos los endpoints   
public class HelloWorldController : ControllerBase
{

    IHelloWorldService helloWorldService;

    // Tenemos que resiviarla por el construcutor 
    public HelloWorldController(IHelloWorldService helloWorld)
    {
        helloWorldService = helloWorld; 
    }

    public IActionResult Get()
    {
        return Ok(helloWorldService.GetHelloWorld());
    }
}
