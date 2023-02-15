using MapvisionTask.Data.Models;
using MapvisionTask.Data.Repositories;

namespace MapvisionTask.Data.Queries
{
    public class PartPointsQueries : IPartPointsQueries
    {
        private readonly IPartPointsQueriesRepository _repository;
        public PartPointsQueries(IPartPointsQueriesRepository repository)
        {
            _repository = repository;
        }
        /// <returns>Return all values from csv file.</returns>
        public IEnumerable<PartPoint> GetAllPartPoints()
        {
            if (!IsDataAvailable())
                throw new Exception("Problem with the connection with csv file.");

            return _repository.GetAllData();
        }
        /// <returns>Return all values from csv file that related to an axis.</returns>
        public IEnumerable<double>? GetAxisValues(EnumAxis enumAxis)
        {
            try
            {
                if (!IsDataAvailable())
                    throw new Exception("Problem with the connection with csv file.");

                switch (enumAxis)
                {
                    case EnumAxis.X: return GetXValues();
                    case EnumAxis.Y: return GetYValues();
                    case EnumAxis.Z: return GetZValues();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private IEnumerable<double> GetXValues()
        {
            return _repository.GetAllData().Select(x => x.X);
        }
        private IEnumerable<double> GetYValues()
        {
            return _repository.GetAllData().Select(x => x.Y);
        }
        private IEnumerable<double> GetZValues()
        {
            return _repository.GetAllData().Select(x => x.Z);
        }
        private bool IsDataAvailable()
        => _repository.IsDataAvailable();
    }
}
