using System;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using ServiceBusLab;
using ServiceBusQueuesLab.Contracts;

namespace ServiceBusQueuesLab
{
    public static class MessageProcessor
    {
        public static Task ProcessMessageAsync(BrokeredMessage message)
        {
            return ActualProcessAsync(new StatisticsProcesser(), new GameStatisticsWriter(), message);
        }

        private static Task ActualProcessAsync(
            IStatisticsProcesser decider,
            IGameStatisticsWriter publisher,
            BrokeredMessage message)
        {
            throw new NotImplementedException();
        }
    }
}