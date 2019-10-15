using Domain;
using System;

namespace Application
{
    public class AddTimeRecordHandler : IAddTimeRecordHandler
    {
        private readonly ITimeKeeperRepository _timeKeeperRepository;

        public AddTimeRecordHandler(ITimeKeeperRepository timeKeeperRepository)
        {
            _timeKeeperRepository = timeKeeperRepository;
        }

        public void Handle(AddTimeRecord addTimeRecord)
        {
            try
            {
                var timeRecord = new TimeRecord(DateTime.Now, addTimeRecord.Author, (Domain.EventType.EventTypeEnum)addTimeRecord.Event);
                _timeKeeperRepository.Save(timeRecord);
            }
            catch 
            {
                throw new Exception();
            }           
        }
    }
}
