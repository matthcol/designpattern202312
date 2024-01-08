using GeometryFacade.Computing;
using GeometryFacade.Model;

namespace GeometryComputingTests
{
    public class GeometryComputerFacadeTests
    {

        private IGeometryComputer _computer;

        [SetUp]
        public void Setup()
        {
            _computer = new GeometryComputerFacade();
        }

        [Test]
        public void DistanceTest()
        {
            IPoint p1 = new IntPoint() { X = 1, Y = 3 };
            IPoint p2 = new IntPoint() { X = 4, Y = -1 };
            double actualDistance = _computer.Distance(p1, p2);
            Assert.That(actualDistance, Is.EqualTo(5.0));
        }

        [TestCase(1)]
        [TestCase(1_000)]
        [TestCase(1_000_000)]
        [TestCase(500_000_000)]
        [TestCase(1_000_000_000)]
        public void DistanceTest_Scales(int scale)
        {
            IPoint p1 = new IntPoint() { X = 1*scale, Y = 3*scale };
            IPoint p2 = new IntPoint() { X = 4*scale, Y = -1*scale };
            double actualDistance = _computer.Distance(p1, p2);
            Assert.That(actualDistance, Is.EqualTo(5.0*scale));
        }
    }
}