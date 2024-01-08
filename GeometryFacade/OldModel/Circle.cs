using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldGeometry.Model
{
    public class Circle
    {
        public Point Center {  get; set; }
        public double Radius { get; set; }
        public double Surface => Math.PI * Radius * Radius;
        public double Perimeter => 2 * Math.PI * Radius;
    }
}
