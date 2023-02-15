using CsvHelper.Configuration.Attributes;

namespace MapvisionTask.Data.Models
{
    public class PartPoint
    {

        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public double X { get; set; }
        [Index(2)]
        public double Y { get; set; }
        [Index(3)]
        public double Z { get; set; }
    }
}
