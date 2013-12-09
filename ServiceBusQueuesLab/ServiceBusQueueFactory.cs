using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using ServiceBusLab.Contracts;

namespace ServiceBusLab
{
    public class ServiceBusQueueFactory : IQueueFactory
    {
        public Task<QueueClient> CreateQueueAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}