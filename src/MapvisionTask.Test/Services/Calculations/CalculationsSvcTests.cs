using MapvisionTask.Data.Models;
using MapvisionTask.Services.Models;
using MapvisionTask.Tests.Services.MockModels;

namespace MapvisionTask.Tests.Services.Calculations
{
    public class PartPointsQueriesTests
    {
        private Mock<PartPointsQueriesRepository> _partPointsQueriesRepositoryMock;
        private Mock<PartPointsQueries> _partPointsQueriesMock;
        private CalculationsSvc _target;
        [SetUp]
        public void Setup()
        {
            _partPointsQueriesRepositoryMock = new Mock<PartPointsQueriesRepository>();
            _partPointsQueriesMock = new Mock<PartPointsQueries>(_partPointsQueriesRepositoryMock.Object);
            _target = new CalculationsSvc(_partPointsQueriesMock.Object);
        }
        [TestCase(new double[] { 50 ,55 , 45 , 60 , 40 }, 50)]
        [TestCase(new double[] { 6, 9, 4, 2, 5 }, 5.36)]
        [TestCase(new double[] { 2.5, 5.5, 3.5, 6.5, 1.5 }, 3.44)]
        [TestCase(new double[] { 1.2, 2.4, 3.6, 4.8, 6.0 }, 2.88)]
        [TestCase(new double[] { 2059.14, 2059.24, 2059.45, 2059.49, 2059.51}, 0.02)]
        public void CalculatePopulationVariance_ReturnsCorrectValue(double[] data, double variance)
        {   
            // act
            var result = _target.CalculatePopulationVariance(data);

            // assert
            Assert.NotNull(result);
            Assert.That(result, Is.EqualTo(variance));
        }
        [Test]
        public void CheckTrend_Increasing()
        {
            //Arrange
            var list = new List<MockPartPoint>() { new (1,2,3,4), new(2, 20, 30, 40), new(3, 200, 300, 400) };
            // act
            var result = _target.CheckTrend(list.ConvertAll(x => (PartPoint)x));

            // assert
            Assert.NotNull(result);
            Assert.IsTrue(result == Trend.Increasing);
        }
        [Test]
        public void CheckTrend_Decreasing()
        {
            //Arrange
            var list = new List<MockPartPoint>() {  new (2, -3, 10, 0), new(3, 20, -30, -10), new(3, 20, -300, -100) };
            // act
            var result = _target.CheckTrend(list.ConvertAll(x => (PartPoint)x));

            // assert
            Assert.NotNull(result);
            Assert.IsTrue(result == Trend.Decreasing);
        }
        [Test]
        public void CheckTrend_Flat()
        {
            //Arrange
            var list = new List<MockPartPoint>() { new(3, 2, 10, 20), new(3, 1, 10, 20), new(3, 2, 10, 20) };
            // act
            var result = _target.CheckTrend(list.ConvertAll(x => (PartPoint)x));

            // assert
            Assert.NotNull(result);
            Assert.IsTrue(result == Trend.Flat);
        }
        [TestCase(new double[] { 22, 24, 25, 28, 29, 31, 35, 37, 41, 53, 64 }, 64)]
        [TestCase(new double[] { 378.09,378.01,378.57,378.76,378.45,378.67,378.11,378.55,378.04,378.18,378.24,378.8,378.85,379.9 }, 379.9)]
        public void CalculateOutliers_ReturnsOutlier(double[] data, double outlier)
        {
            // act
            var result = _target.CalculateOutliers(data.ToList());

            // assert
            Assert.NotNull(result);
            Assert.IsTrue(result.Any(x=>x == outlier));
        }
        [TestCase(new double[] { 378.09, 378.01, 378.57, 378.76, 378.45, 378.67, 378.11, 378.55, 378.04, 378.18, 378.24, 378.8, 378.85 })]
        public void CalculateOutliers_ReturnsNoOutlier(double[] data)
        {
            // act
            var result = _target.CalculateOutliers(data.ToList());

            // assert
            Assert.NotNull(result);
            Assert.IsTrue(result.Count()==0);
        }
    }
}