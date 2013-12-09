using Microsoft.ServiceBus.Messaging;
using ServiceBusQueuesLab.Contracts;

namespace ServiceBusQueuesLab
{
    public class ServiceBusQueueFactory : IQueueFactory
    {
        public QueueClient Create()
        {
            throw new System.NotImplementedException();
        }
    }
}