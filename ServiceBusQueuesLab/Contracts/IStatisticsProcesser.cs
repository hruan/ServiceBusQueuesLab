using System.Threading.Tasks;
using ServiceBusLab.Shared.Domain;

namespace ServiceBusLab.Contracts
{
    public interface IStatisticsProcesser
    {
        /// <summary>
        /// Given a game crunch the game statistics
        /// </summary>
        Task<GameStatistics> ProcessAsync(GameData game);
    }
}