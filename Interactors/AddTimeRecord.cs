using Domain;

namespace Application
{
    public class AddTimeRecord
    {
        public AddTimeRecord(string author, EventType.EventTypeEnum eventType)
        {
            Author = author;
            Event = eventType;
        }

        public string Author { get; }
        public EventType.EventTypeEnum   Event { get; }
    }
}