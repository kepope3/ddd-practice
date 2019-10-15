using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public class TimeKeeperRepository : ITimeKeeperRepository
    {
        private List<TimeRecord> _timeRecords = new List<TimeRecord>();
        public void Save(TimeRecord timeRecord)
        {
            _timeRecords.Add(timeRecord);
        }
    }
}
