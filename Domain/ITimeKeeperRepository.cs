
namespace Domain
{
    public interface ITimeKeeperRepository
    {
        void Save(TimeRecord timeRecord);
    }
}