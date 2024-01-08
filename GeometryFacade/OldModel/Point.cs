using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldGeometry.Model
{
    public class Point
    {
        public double X {  get; set; }
        public double Y { get; set; } 
        
        public double Distance(Point other) => Double.Hypot(this.X - other.X, this.Y - other.Y);
    }
}
