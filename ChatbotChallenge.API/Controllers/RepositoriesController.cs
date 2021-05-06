using Microsoft.AspNetCore.Mvc;

namespace ChatbotChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoriesController : ControllerBase
    {
        public RepositoriesController()
        {

        }

        public IActionResult Get()
        {
            return Ok("It's works!");
        }
    }
}
