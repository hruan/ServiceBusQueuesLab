using System;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using ServiceBusQueuesLab.Contracts;

namespace ServiceBusQueuesLab
{
    public class MessageProcessor
    {
        private readonly IStatisticsProcesser _processer = new StatisticsProcesser();
        private readonly IStatisticsWriter _writer = new StatisticsWriter();

        public MessageProcessor(IStatisticsProcesser processer, IStatisticsWriter writer)
        {
            _processer = processer;
            _writer = writer;
        }

        public Task ProcessMessageAsync(BrokeredMessage message)
        {
            return ActualProcessAsync(_processer, _writer, message);
        }

        private static Task ActualProcessAsync(
            IStatisticsProcesser processer,
            IStatisticsWriter writer,
            BrokeredMessage message)
        {
            throw new NotImplementedException();
        }
    }
}