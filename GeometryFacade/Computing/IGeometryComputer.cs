using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFacade.Computing
{
    public interface IGeometryComputer
    {
        double Distance(IPoint p1, IPoint p2);
        double CircleArea(int radius);
        double CirclePerimeter(int radius);
        double PolygonArea(IEnumerable<IPoint> points);
        double PolygonPerimeter(IEnumerable<IPoint> points);
    }
}
