using System;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using ServiceBusQueuesLab.Contracts;

namespace ServiceBusQueuesLab
{
    public static class MessageProcessor
    {
        public static Task ProcessAsync(
            IStatisticsProcesser processer,
            IStatisticsWriter writer,
            BrokeredMessage message)
        {
            throw new NotImplementedException();
        }
    }
}