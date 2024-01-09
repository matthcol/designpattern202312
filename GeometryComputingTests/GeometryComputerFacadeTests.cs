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
        public void DistanceTest_Scales(int scale)
        {
            IPoint p1 = new IntPoint() { X = 1*scale, Y = 3*scale };
            IPoint p2 = new IntPoint() { X = 4*scale, Y = -1*scale };
            double actualDistance = _computer.Distance(p1, p2);
            Assert.That(actualDistance, Is.EqualTo(5.0*scale));
        }

        [Test]
        public void CirclePerimeterTest()
        {
            double actualArea = _computer.CirclePerimeter(3);
            double expectedArea = 18.84955592153876;
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1E-15));
        }

        [Test]
        public void CircleAreaTest()
        {
            double actualArea = _computer.CircleArea(3);
            double expectedArea = 28.274333882308138;
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1E-15));
        }

        [Test]
        public void PolygonPerimeter_WhenTriangle()
        {
            IEnumerable<IPoint> points = [
                new IntPoint { X = 1, Y = 1 },
                new IntPoint { X = 1, Y = 4 },
                new IntPoint { X = 5, Y = 4 },
            ];
            double actualPerimeter = _computer.PolygonPerimeter(points);
            Assert.That(actualPerimeter, Is.EqualTo(12.0));
        }

        [Test]
        public void PolygonPerimeter_WhenSquare()
        {
            IEnumerable<IPoint> points = [
                new IntPoint { X = 1, Y = 1 },
                new IntPoint { X = 1, Y = 4 },
                new IntPoint { X = 5, Y = 4 },
                new IntPoint { X = 5, Y = 1 },
            ];
            double actualPerimeter = _computer.PolygonPerimeter(points);
            Assert.That(actualPerimeter, Is.EqualTo(14.0));
        }

        [Test]
        public void PolygonArea_WhenTriangle()
        {
            IEnumerable<IPoint> points = [
                new IntPoint { X = 1, Y = 1 },
                new IntPoint { X = 1, Y = 4 },
                new IntPoint { X = 5, Y = 4 },
            ];
            double actualArea = _computer.PolygonArea(points);
            Assert.That(actualArea, Is.EqualTo(6.0));
        }

        [Test]
        public void PolygonArea_WhenSquare()
        {
            IEnumerable<IPoint> points = [
                new IntPoint { X = 1, Y = 1 },
                new IntPoint { X = 1, Y = 4 },
                new IntPoint { X = 5, Y = 4 },
                new IntPoint { X = 5, Y = 1 },
            ];
            double actualArea = _computer.PolygonArea(points);
            Assert.That(actualArea, Is.EqualTo(12.0));
        }

    }
}