namespace rconnectAPI.Models
{
    public class Server
    {
        public string? Name { get; set; }
        public required string Host { get; set; }
        public required ushort Port { get; set; }
        public required string RconPassword { get; set; }

        public static explicit operator Server(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Input string cannot be null or empty.", nameof(input));

            var parts = input.Split(':');
            if (parts.Length < 3 || parts.Length > 4)
                throw new FormatException("Input string must be in the format 'Host:Port:RconPassword[:Name]'");

            return new Server
            {
                Host = parts[0],
                Port = ushort.Parse(parts[1]),
                RconPassword = parts[2],
                Name = parts.Length == 4 ? parts[3] : null
            };
        }
    }
}
