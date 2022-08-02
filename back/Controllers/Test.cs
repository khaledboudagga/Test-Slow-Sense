using Microsoft.AspNetCore.Mvc;
using Responses;
namespace back.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    [HttpGet]
    public Response Name()
    {
        Response r = new Response();
        r.Status = 200;
        r.Message = "success";
        return r;
    }
}
