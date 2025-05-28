using rconnectAPI.Models;

namespace rconnectAPI.Services.Interfaces
{
    /// <summary>
    /// Interface for server-related operations.
    /// </summary>
    public interface IServersService
    {
        /// <summary>
        /// Retrieves all server DTOs.
        /// </summary>
        /// <returns>An array of <see cref="ServerDto"/> objects.</returns>
        ServerDto[] GetServerDtos();

        /// <summary>
        /// Gets a specific server by its host name.
        /// </summary>
        /// <param name="host">The host name of the server.</param>
        /// <returns>A <see cref="Server"/> object if found; otherwise, null.</returns>
        Server? GetServer(string host);
    }
}
