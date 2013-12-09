using System.Threading.Tasks;
using ServiceBusQueuesLab.Shared.Domain;

namespace ServiceBusQueuesLab.Contracts
{
    public interface IStatisticsWriter
    {
        /// <summary>
        /// Write the game statistics to given entity
        /// </summary>
        /// <param name="entity">name of the entity to which stats is written</param>
        /// <param name="statistics">game statistics to be written to entity</param>
        Task WriteAsync(string entity, GameStatistics statistics);
    }
}