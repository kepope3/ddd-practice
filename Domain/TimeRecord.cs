using System;

namespace Domain
{
    public class TimeRecord
    {
        public TimeRecord(DateTime time, string author, EventType.EventTypeEnum eventType)
        {
            Time = time;
            Author = author;
            Event = eventType;
        }

        public DateTime Time { get; }
        public string Author { get; }
        public EventType.EventTypeEnum Event { get; }
    }
}
