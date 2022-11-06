using Microsoft.AspNetCore.Mvc;

namespace MashrahAMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    
    [HttpGet]
    [Route("magic8")]
    public string putOut() {
        return "It will throw out random  answer for the player";
    }
   
}




