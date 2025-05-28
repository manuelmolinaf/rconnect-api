namespace rconnectAPI.Services.Interfaces
{
    /// <summary>
    /// Provides functionality to send RCON messages to game servers.
    /// </summary>
    public interface IRconService
    {
        /// <summary>
        /// Sends a command/message to the server identified by the host.
        /// </summary>
        /// <param name="host">The host of the target server.</param>
        /// /// <param name="message">The RCON command/message to send.</param>
        /// <returns>The response from the server as a string.</returns>
        Task<string> SendRconMessage( string host, string message);
    }
}
