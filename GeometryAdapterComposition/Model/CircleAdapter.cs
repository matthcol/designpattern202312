using Geometry.Computing;
using OldGeometry.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model
{
    public class CircleAdapter : IMesurable2D
    {

        public CircleAdapter(Point center, double radius)
        {
            Circle = new()
            {
                Center = center,
                Radius = radius
            };
        }

        private Point Center { 
            get => Circle.Center; 
            set => Circle.Center = value; 
        }
        private double Radius {
            get => Circle.Radius;
            set => Circle.Radius = value; 
        }

        // Adapter by composition
        private Circle Circle { get; set; }

        public double Area => Circle.Surface;

        public double Perimeter => 2 * Math.PI * Radius;
    }
}
