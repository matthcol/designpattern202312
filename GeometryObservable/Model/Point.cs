using GeometryObservable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model
{
    public class Point: AbstractForm
    {
        public Point(String name, double x, double y): base(name)
        {
            _x = x; _y = y;
        }
        public double X { get => _x; set { _x = value; NotifyAll(); } }
        public double Y { get => _y; set { _y = value; NotifyAll(); } }
        
        public double Distance(Point other) => Double.Hypot(this.X - other.X, this.Y - other.Y);

        public override string ToString() => $"{Name} ({X}; {Y})";

        private double _x;
        private double _y;
    }
}
