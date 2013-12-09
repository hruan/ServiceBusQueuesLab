using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using ServiceBusQueuesLab.Contracts;

namespace ServiceBusQueuesLab
{
    public class ServiceBusQueueFactory : IQueueFactory
    {
        public Task<QueueClient> CreateQueueAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}