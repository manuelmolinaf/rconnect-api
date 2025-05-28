namespace rconnectAPI.Models
{
    public class ServerDto
    {
        public string? Name { get; set; }
        public required string Host { get; set; }
        public required ushort Port { get; set; }


        public static explicit operator ServerDto(Server input)
        {
 
            return new ServerDto
            {
                Host = input.Host,
                Port = input.Port,
                Name = string.IsNullOrEmpty(input.Name) ? null : input.Name
            };
        }
    }
}
