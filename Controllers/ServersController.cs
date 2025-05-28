using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rconnectAPI.Models;
using rconnectAPI.Services;

namespace rconnectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServersController(ServersService servesService) : ControllerBase
    {
        private readonly ServersService _serversService = servesService;

        [HttpGet(Name = "GetServes")]
        public ActionResult<IEnumerable<ServerDto>> GetServes()
        {
            return Ok(_serversService.GetServerDtos());
        }
    }
}
