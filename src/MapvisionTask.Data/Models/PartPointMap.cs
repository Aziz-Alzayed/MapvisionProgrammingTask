using CsvHelper.Configuration;

namespace MapvisionTask.Data.Models
{
    public class PartPointMap : ClassMap<PartPoint>
    {
        public PartPointMap()
        {
            Map(p => p.Id).Index(0);
            Map(p => p.X).Index(1);
            Map(p => p.Y).Index(2);
            Map(p => p.Z).Index(3);
        }
    }
}
