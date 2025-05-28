using rconnectAPI.Models;
using rconnectAPI.Services.Interfaces;

namespace rconnectAPI.Services.Concrete
{
    public class ServersService: IServersService
    {
        private readonly Server[] servers = [];

        public ServersService() {

            servers = [.. DotNetEnv.Env.GetString("SERVERS").Split(',').Select(serverString => (Server)serverString)];
        }

        public ServerDto[] GetServerDtos()
        {
            return [.. servers.Select(s => (ServerDto)s)];
        }

        public Server? GetServer(string host)
        {
            return servers.FirstOrDefault(s => s.Host == host);
        }


    }
}
