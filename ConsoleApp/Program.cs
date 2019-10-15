using Application;
using Domain;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddScoped<IAddTimeRecordHandler, AddTimeRecordHandler>()
            .AddScoped<ITimeKeeperRepository, TimeKeeperRepository>()
            .AddTransient<Input>()
            .BuildServiceProvider();

            var input = serviceProvider.GetService<Input>();

            input.NewInput("Keith", "presentation");
        }
    }

    class Input
    {
        private readonly IAddTimeRecordHandler _addTimeRecordHandler;

        public Input(IAddTimeRecordHandler addTimeRecordHandler)
        {
            _addTimeRecordHandler = addTimeRecordHandler;
        }

        public void NewInput(string author, string eventTypeString)
        {
            try
            {
                var eventType = (EventType.EventTypeEnum)Enum.Parse(typeof(EventType.EventTypeEnum), eventTypeString);

                _addTimeRecordHandler.Handle(new AddTimeRecord(author, eventType));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
