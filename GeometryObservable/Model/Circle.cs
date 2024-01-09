using GeometryObservable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model
{
    public class Circle: AbstractForm
    {
        public Circle(String name, Point center, double radius): base(name)
        {
            _center = center;
            _radius = radius;
        }

        public Point Center {  
            get => _center; 
            set
            {
                _center = value;
                NotifyAll();
            }
        }
        public double Radius {
            get => _radius;
            set
            {
                _radius = value;
                NotifyAll();
            }
        }
        public double Surface => Math.PI * Radius * Radius;
        public double Perimeter => 2 * Math.PI * Radius;

        public override string ToString() => $"{Name} <c:{Center}; r={Radius}>)";

        private Point _center;
        private double _radius;
    }
}
