using System;
using System.Threading.Tasks;
using ServiceBusLab.Shared.Domain;
using ServiceBusQueuesLab.Contracts;

namespace ServiceBusQueuesLab
{
    public class GameStatisticsWriter : IGameStatisticsWriter
    {
        public Task WriteAsync(string entity, GameStatistics result)
        {
            throw new NotImplementedException();
        }
    }
}