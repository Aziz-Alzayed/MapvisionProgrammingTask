using MapvisionTask.Data.Models;
using MapvisionTask.Services.Models;

namespace MapvisionTask.Services.Calculations
{
    public interface ICalculationsSvc
    {
        public double GetVariance(EnumAxis enumAxis);
        public double CalculatePopulationVariance(IEnumerable<double> newList);
        public IEnumerable<PartPoint> GetOutlier(out List<double> xOutliers, out List<double> yOutliers, out List<double> zOutliers);
        public List<double> CalculateOutliers(List<double> values);
        public string CheckTrend();
        public Trend CheckTrend(List<PartPoint> points);
    }
}
