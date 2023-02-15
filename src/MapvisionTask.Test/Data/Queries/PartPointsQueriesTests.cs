namespace MapvisionTask.Tests.Data.Queries
{
    public class CalculationsSvcTests
    {
        private  Mock<PartPointsQueriesRepository> _partPointsQueriesRepositoryMock;
        private  PartPointsQueries _target;
        [SetUp]
        public void Setup()
        {
            _partPointsQueriesRepositoryMock = new Mock<PartPointsQueriesRepository>();
            _target = new PartPointsQueries(_partPointsQueriesRepositoryMock.Object);
        }
        [TestCase(21)]
        public void GetAllPartPoints_ValidData_Returns20RowsValues_OK(int recordsCount)
        {
            // act
            var result = _target.GetAllPartPoints();

            // assert
            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(recordsCount));
        }
        [TestCase(21)]
        public void GetAxisValues_ValidData_Returns20Xcounts_OK(int recordsCount)
        {
            // act
            var result = _target.GetAxisValues(MapvisionTask.Data.Models.EnumAxis.X);

            // assert
            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(recordsCount));
        }
        [TestCase(21)]
        public void GetAxisValues_ValidData_Returns20Ycounts_OK(int recordsCount)
        {
            // act
            var result = _target.GetAxisValues(MapvisionTask.Data.Models.EnumAxis.Y);

            // assert
            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(recordsCount));
        }
        [TestCase(21)]
        public void GetAxisValues_ValidData_Returns20Zcounts_OK(int recordsCount)
        {
            // act
            var result = _target.GetAxisValues(MapvisionTask.Data.Models.EnumAxis.Z);

            // assert
            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(recordsCount));
        }
    }
}