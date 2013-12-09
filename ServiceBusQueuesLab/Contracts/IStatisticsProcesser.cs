using ServiceBusQueuesLab.Shared.Domain;

namespace ServiceBusQueuesLab.Contracts
{
    public interface IStatisticsProcesser
    {
        /// <summary>
        /// Given a game crunch the game statistics
        /// </summary>
        GameStatistics Process(GameData game);
    }
}