using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldGeometry.Model
{
    public class Polygon
    {
        public IList<Point> Summits { get; set; } = new List<Point>();

        public double Surface { get => 0.0; }
        public double Perimeter { get => 0.0; }
    }
}
