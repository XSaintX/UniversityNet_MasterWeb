using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterNet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("getstring")]
        public string GetNombre()
        {
            return "Vaxidrez.com";
        }
    }
}
