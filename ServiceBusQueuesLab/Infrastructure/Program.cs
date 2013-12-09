using System;
using System.Threading;
using System.Threading.Tasks;
using ServiceBusLab.Contracts;

namespace ServiceBusLab.Infrastructure
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

        private static async Task Run(IQueueFactory queueFactory)
        {
            var q = await queueFactory.CreateQueueAsync();
            q.OnMessageAsync(MessageProcessor.ProcessMessageAsync);
        }
    }
}