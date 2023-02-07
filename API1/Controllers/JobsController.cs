using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    public class JobsController : ControllerBase
    {
        
        public async Task<IActionResult> Get()
        {
            return Ok("Hola mundo Steven Api");
        }
    }
}
