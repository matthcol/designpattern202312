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
        public double CircleArea(int radius)
        {
            throw new NotImplementedException();
        }

        public double CirclePerimeter(int radius)
        {
            throw new NotImplementedException();
        }

        public double Distance(IPoint p1, IPoint p2)
        {
            Point doubleP1 = new Point { X = p1.X, Y = p1.Y };
            Point doubleP2 = new Point { X = p2.X, Y = p2.Y };
            return doubleP1.Distance(doubleP2);
        }

        public double PolygonArea(IList<IPoint> points)
        {
            throw new NotImplementedException();
        }

        public double PolygonPerimeter(IList<IPoint> points)
        {
            throw new NotImplementedException();
        }
    }
}
