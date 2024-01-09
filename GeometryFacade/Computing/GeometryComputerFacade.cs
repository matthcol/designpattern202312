using OldGeometry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFacade.Computing
{
    public class GeometryComputerFacade : IGeometryComputer
    {

        private Circle _circle;
        public GeometryComputerFacade() { 
            _circle = new Circle() { Radius = 1 };
        }

        public double CircleArea(int radius)
        {
            _circle.Radius = radius;
            return _circle.Surface;
        }

        public double CirclePerimeter(int radius)
        {
            _circle.Radius = radius;
            return _circle.Perimeter;
        }

        public double Distance(IPoint p1, IPoint p2)
        {
            Point doubleP1 = new Point { X = p1.X, Y = p1.Y };
            Point doubleP2 = new Point { X = p2.X, Y = p2.Y };
            return doubleP1.Distance(doubleP2);
        }

        public double PolygonArea(IEnumerable<IPoint> points)
        {
            Polygon polygon = new Polygon() { Summits = points.Select(
                    p => new Point() { X = p.X, Y = p.Y }
                ).ToList() };
            return polygon.Surface;
        }

        public double PolygonPerimeter(IEnumerable<IPoint> points)
        {
            Polygon polygon = new Polygon()
            {
                Summits = points.Select(
                    p => new Point() { X = p.X, Y = p.Y }
                ).ToList()
            };
            return polygon.Perimeter;
        }
    }
}
