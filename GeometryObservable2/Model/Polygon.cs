using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model
{
    public class Polygon
    {
        public IList<Point> Summits { get; set; } = new List<Point>();

        public double Surface { get {
                if (Summits.Count < 3) return 0.0; // or Exception
                // NB: following code only works for aconvex polygon
                Point p1 = Summits[0];
                double surface = 0.0;
                for (int i = 1; i < Summits.Count - 1; i++)
                {
                    Point p2 = Summits[i];
                    Point p3 = Summits[i + 1];
                    surface += TriangleArea(
                        p1.Distance(p2),
                        p2.Distance(p3),
                        p3.Distance(p1)
                    );
                }
                return surface;
            } 
        }

        public double Perimeter => Summits.Select(
                (p, i) => p.Distance(Summits[(i + 1) % Summits.Count])
            ).Sum();

        public static double TriangleArea(double a, double b, double c) => Math.Sqrt(
                (a+(b+c)) * (c - (a-b)) * (c + (a-b)) * (a + (b-c))
            ) / 4.0;
    }
}
