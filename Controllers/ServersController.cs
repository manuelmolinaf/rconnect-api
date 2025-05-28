using Microsoft.AspNetCore.Mvc;
using rconnectAPI.Models;
using rconnectAPI.Services.Concrete;
using rconnectAPI.Services.Interfaces;

namespace rconnectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServersController(IServersService servesService, IRconService rconService) : ControllerBase
    {
        private readonly IServersService _serversService = servesService;
        private readonly IRconService _rconService = rconService;

        [HttpGet("GetServers")]
        public ActionResult<IEnumerable<ServerDto>> GetServers()
        {
            return Ok(_serversService.GetServerDtos());
        }

        [HttpPost("SendMessage")]
        public async Task<ActionResult<string>> SendMessage([FromBody] RconMessageRequest request)
        {
            string response = await _rconService.SendRconMessage(request.Host, request.Message);
            return Ok(response);
        }


    }
}
