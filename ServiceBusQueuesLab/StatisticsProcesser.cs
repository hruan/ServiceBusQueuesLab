using System;
using System.Threading.Tasks;
using ServiceBusQueuesLab.Contracts;
using ServiceBusQueuesLab.Shared.Domain;

namespace ServiceBusQueuesLab
{
    public class StatisticsProcesser : IStatisticsProcesser
    {
        public Task<GameStatistics> ProcessAsync(GameData game)
        {
            throw new NotImplementedException();
        }
    }
}