using JoaoHong.APICollection.Models;
using Microsoft.AspNetCore.Mvc;
namespace JoaoHong.APICollection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : Controller
    {
        [HttpPost(Name = "Authentication")]
        public async Task<IActionResult> Authentication([FromBody]AuthenticationModel model)
        {
            
            return Ok(model);
        }
    }
}
