using CoreRCON;
using rconnectAPI.Services.Interfaces;
using System.Net;

namespace rconnectAPI.Services.Concrete
{
    public class RconService(IServersService serversService ) : IRconService
    {
        private readonly IServersService _serversService = serversService;

        public async Task<string> SendRconMessage(string host, string message)
        {
            var server = _serversService.GetServer(host) ?? throw new ArgumentException($"Server with host '{host}' not found.");

            var rcon = new RCON(IPAddress.Parse(server.Host), server.Port, server.RconPassword);

            string response = await rcon.SendCommandAsync(message);

            return response;
        }
    }
}
