using CsvHelper.Configuration;
using CsvHelper;
using MapvisionTask.Data.Models;
using System.Globalization;
using System.Reflection;

namespace MapvisionTask.Data.Repositories
{
    public class PartPointsQueriesRepository : IPartPointsQueriesRepository
    {
        private const string DataFileName = "MapvisionTask.Data.Data.Data.csv";
        public PartPointsQueriesRepository()
        {}
        public IEnumerable<PartPoint> GetAllData()
        {
            try
            {
                IEnumerable<PartPoint> points;
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",",
                    Comment = '#',
                    HasHeaderRecord = true
                };
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (var reader = new StreamReader(assembly.GetManifestResourceStream(DataFileName)))
                using (var csv = new CsvReader(reader, configuration))
                {
                    csv.Context.RegisterClassMap<PartPointMap>();
                    points = csv.GetRecords<PartPoint>().ToList();
                }

                return points;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public bool IsDataAvailable()
        => Assembly.GetExecutingAssembly().GetManifestResourceNames().Contains(DataFileName);       
    }
}
