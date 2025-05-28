using CoreRCON;
using rconnectAPI.Models;
using System.Net;

namespace rconnectAPI.Services
{
    public class RconService
    {


        public async Task<string> SendRconMessage(string message, Server server)
        {
           
            var rcon = new RCON(IPAddress.Parse(server.Host), server.Port, server.RconPassword);

            string response = await rcon.SendCommandAsync(message);

            return response;
        }
    }
}
