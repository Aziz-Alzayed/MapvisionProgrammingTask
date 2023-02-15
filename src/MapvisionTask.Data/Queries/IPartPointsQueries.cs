using MapvisionTask.Data.Models;

namespace MapvisionTask.Data.Queries
{
    public interface IPartPointsQueries
    {
        public IEnumerable<PartPoint> GetAllPartPoints();
        public IEnumerable<double>? GetAxisValues(EnumAxis enumAxis);
    }
}
