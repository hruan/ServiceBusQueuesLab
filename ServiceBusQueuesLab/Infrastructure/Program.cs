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
            Task.Run(() => Run(new ServiceBusQueueFactory()), cts.Token);

            Console.ReadLine();
            cts.Cancel();
        }

        private static void Run(IQueueFactory queueFactory)
        {
            var processor = new MessageProcessor(new StatisticsProcesser(), new StatisticsWriter());
            var q = queueFactory.Create();
            q.OnMessageAsync(processor.ProcessMessageAsync, new OnMessageOptions {AutoComplete = false});
        }
    }
}