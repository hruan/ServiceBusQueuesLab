using System;
using System.Threading.Tasks;
using ServiceBusLab.Shared.Domain;
using ServiceBusQueuesLab.Contracts;

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