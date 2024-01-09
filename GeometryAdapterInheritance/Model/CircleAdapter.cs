using Geometry.Computing;
using OldGeometry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model
{
    public class CircleAdapter : Circle, IMesurable2D
    {
        // Adapter by inheritance

        public CircleAdapter(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        // method adapter
        public double Area => Surface;

        public double Perimeter => 2 * Math.PI * Radius;
    }
}
