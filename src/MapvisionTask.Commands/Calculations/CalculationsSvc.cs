using MapvisionTask.Data.Models;
using MapvisionTask.Data.Queries;
using MapvisionTask.Services.Models;
using MathNet.Numerics.LinearRegression;

namespace MapvisionTask.Services.Calculations
{
    public class CalculationsSvc: ICalculationsSvc
    {
        private readonly IPartPointsQueries _partPointsQueries;
        public CalculationsSvc(IPartPointsQueries partPointsQueries) {
            _partPointsQueries = partPointsQueries;
        }
        public double GetVariance(EnumAxis enumAxis)
        {
            var points = _partPointsQueries.GetAxisValues((EnumAxis)enumAxis);
            return CalculatePopulationVariance(points);
        }
        public string CheckTrend()
        {
            var points = _partPointsQueries.GetAllPartPoints();
            return CheckTrend(points.ToList()).ToString();
        }
        /// <summary>
        /// Use Simple Regression slope to determine the status of the slopes for list of PartPoints.
        /// </summary>
        /// <param name="points"></param>
        /// <returns>Trends: Increasing, Decreasing, Flat.</returns>
        public Trend CheckTrend(List<PartPoint> points)
        {
            var x = points.Select(x=>x.X)?.ToArray();
            var y = points.Select(y=>y.Y)?.ToArray();
            var z = points.Select(z=>z.Z)?.ToArray();

            var xyTrend = SimpleRegression.Fit(x, y);
            var xzTrend = SimpleRegression.Fit(x, z);
            var yzTrend = SimpleRegression.Fit(y, z);

            double xySlope = xyTrend.Item2;
            double xzSlope = xzTrend.Item2;
            double yzSlope = yzTrend.Item2;

            //If all of the slopes are more than zero mark it as Increasing.
            if (xySlope > 0 && xzSlope > 0 && yzSlope > 0)
            {
                return Trend.Increasing;
            }
            //If any of the slopes has negative value mark it as Decreasing.
            else if (xySlope < 0 || xzSlope < 0 || yzSlope < 0)
            {
                return Trend.Decreasing;
            }
            // Otherwise mark it as Flat.
            else
            {
                return Trend.Flat;
            }
        }
        public IEnumerable<PartPoint> GetOutlier(out List<double> xOutliers, out List<double> yOutliers, out List<double> zOutliers)
        {
            try
            {
                xOutliers=new List<double>(); 
                yOutliers=new List<double>(); 
                zOutliers=new List<double>();
                var points = _partPointsQueries.GetAllPartPoints();
                var result = new List<PartPoint>();
                if (points.Any())
                {
                    xOutliers = CalculateOutliers(points.Select(x => x.X).ToList());
                    yOutliers = CalculateOutliers(points.Select(x => x.Y).ToList());
                    zOutliers = CalculateOutliers(points.Select(x => x.Z).ToList());

                    foreach(var point in points)
                    {
                        if(xOutliers.Any(x=>x== point.X)|| yOutliers.Any(y => y == point.Y)|| zOutliers.Any(z => z == point.Z))
                        {
                            result.Add(point);
                        }
                    }

                    return result;
                }
                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }
        /// <summary>
        /// Using Statistical outlier detection Z-score. 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public List<double> CalculateOutliers(List<double> data)
        {
            List<double> outLierNumbers = new List<double>();
            // calculate mean and standard deviation
            double mean = data.Average();
            double standardDeviation = Math.Sqrt(data.Average(v => Math.Pow(v - mean, 2)));
            // calculate Z-Score for each data point
            double[] zScores = data.Select(x => (x - mean) / standardDeviation).ToArray();

            // define outlier threshold
            double threshold = 2.0;

            // detect outliers
            for (int i = 0; i < data.Count(); i++)
            {
                if (Math.Abs(zScores[i]) > threshold)
                {
                    outLierNumbers.Add(data[i]);
                }
            }
            return outLierNumbers.ToList();
        }
        /// <summary>
        /// Calculating the Population Variance of a double list using formula σ2 = ∑ (xi – x̄)2/(n – 1).
        /// </summary>
        /// <returns>Population Variance value.</returns>
        public double CalculatePopulationVariance(IEnumerable<double> data)
        {
            try
            {
                if (data.Any())
                {
                    double mean = data.Sum()/data.Count();
                    double sumOfSquares = 0;
                    foreach (double value in data)
                    {
                        double difference = value - mean;
                        sumOfSquares += difference * difference;
                    }
                    var variance = sumOfSquares / data.Count();

                    return Math.Round(variance, 2, MidpointRounding.ToEven);
                }
                else { return 0.0; }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }  
    }
}
