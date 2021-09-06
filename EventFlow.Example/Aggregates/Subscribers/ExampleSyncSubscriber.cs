using System;
using System.Threading;
using System.Threading.Tasks;
using EventFlow.Aggregates;
using EventFlow.Subscribers;
using EventFlowExample.Aggregates.Events;
using Hangfire;

namespace EventFlowExample.Aggregates.Subscribers
{
    public class ExampleSyncSubscriber : ISubscribeAsynchronousTo<ExampleAggregate, ExampleId, ExampleEvent>
    {
        public Task HandleAsync(IDomainEvent<ExampleAggregate, ExampleId, ExampleEvent> domainEvent, CancellationToken cancellationToken)
        {
            return Task.Run(async () =>
            { 
                Console.WriteLine("++++++++" + domainEvent.ToString());
                Console.WriteLine("++++++++ I am doing something BIG!");

                await Task.Delay(5000);
            });
        }            
    }
}