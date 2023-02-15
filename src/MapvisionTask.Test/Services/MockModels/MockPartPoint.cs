using MapvisionTask.Data.Models;

namespace MapvisionTask.Tests.Services.MockModels
{
    internal class MockPartPoint:PartPoint
    {
        public MockPartPoint(int id, double x, double y, double z)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
