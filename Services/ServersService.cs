using rconnectAPI.Models;

namespace rconnectAPI.Services
{
    public class ServersService
    {
        readonly private Server[] servers = [];

        public ServersService() {

            servers = [.. DotNetEnv.Env.GetString("SERVERS").Split(',').Select(serverString => (Server)serverString)];
        }

        public ServerDto[] GetServerDtos()
        {
            return [.. servers.Select(s => (ServerDto)s)];
        }
    }
}
