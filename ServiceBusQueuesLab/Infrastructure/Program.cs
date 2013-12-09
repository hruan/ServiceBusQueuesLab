using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using ServiceBusQueuesLab.Contracts;

namespace ServiceBusQueuesLab.Infrastructure
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            Task.Run(() =>
                Run(new ServiceBusQueueFactory(),
                    new StatisticsProcesser(),
                    new StatisticsWriter()),
                cts.Token);

            Console.ReadLine();
            cts.Cancel();
        }

        private static void Run(
            IQueueFactory queueFactory,
            IStatisticsProcesser processer,
            IStatisticsWriter writer)
        {
            var q = queueFactory.Create();
            q.OnMessageAsync(msg => MessageProcessor.ProcessAsync(processer, writer, msg),
                new OnMessageOptions {AutoComplete = false});
        }
    }
}