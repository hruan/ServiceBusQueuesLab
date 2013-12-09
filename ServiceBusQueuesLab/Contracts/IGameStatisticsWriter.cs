using System.Threading.Tasks;
using ServiceBusLab.Shared.Domain;

namespace ServiceBusQueuesLab.Contracts
{
    public interface IGameStatisticsWriter
    {
        /// <summary>
        /// Write the game statistics to given entity
        /// </summary>
        /// <param name="entity">name of the entity to which stats is written</param>
        /// <param name="result">game statistics to be written to entity</param>
        Task WriteAsync(string entity, GameStatistics result);
    }
}