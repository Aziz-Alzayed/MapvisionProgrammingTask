using MapvisionTask.Data.Models;

namespace MapvisionTask.Data.Repositories
{
    public interface IPartPointsQueriesRepository
    {
        public bool IsDataAvailable();
        public IEnumerable<PartPoint> GetAllData();
    }
}
