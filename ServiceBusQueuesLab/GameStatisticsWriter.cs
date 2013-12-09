using System;
using System.Threading.Tasks;
using ServiceBusLab.Contracts;
using ServiceBusLab.Shared.Domain;

namespace ServiceBusLab
{
    public class GameStatisticsWriter : IGameStatisticsWriter
    {
        public Task WriteAsync(string entity, GameStatistics result)
        {
            throw new NotImplementedException();
        }
    }
}