using System.Threading.Tasks;
using ServiceBusQueuesLab.Shared.Domain;

namespace ServiceBusQueuesLab.Contracts
{
    public interface IStatisticsProcesser
    {
        /// <summary>
        /// Given a game crunch the game statistics
        /// </summary>
        Task<GameStatistics> ProcessAsync(GameData game);
    }
}