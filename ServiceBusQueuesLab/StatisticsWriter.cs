using System;
using System.Threading.Tasks;
using ServiceBusQueuesLab.Contracts;
using ServiceBusQueuesLab.Shared.Domain;

namespace ServiceBusQueuesLab
{
    public class StatisticsWriter : IStatisticsWriter
    {
        public Task WriteAsync(string entity, GameStatistics statistics)
        {
            throw new NotImplementedException();
        }
    }
}