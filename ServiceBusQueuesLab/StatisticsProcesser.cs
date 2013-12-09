using System;
using System.Threading.Tasks;
using ServiceBusLab.Contracts;
using ServiceBusLab.Shared.Domain;

namespace ServiceBusLab
{
    public class StatisticsProcesser : IStatisticsProcesser
    {
        public Task<GameStatistics> ProcessAsync(GameData game)
        {
            throw new NotImplementedException();
        }
    }
}