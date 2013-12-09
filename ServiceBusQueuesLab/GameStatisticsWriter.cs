using System;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using ServiceBusQueuesLab.Contracts;
using ServiceBusQueuesLab.Shared.Domain;

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