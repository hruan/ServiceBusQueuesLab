using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace ServiceBusLab.Contracts
{
    public interface IQueueFactory
    {
        /// <summary>
        /// Provides a queue from which message are received and passed on to
        /// processing
        /// </summary>
        /// <returns></returns>
        Task<QueueClient> CreateQueueAsync();
    }
}