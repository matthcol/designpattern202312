using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Computing
{
    public static class Compute
    {
        public static double TotalArea(IEnumerable<IMesurable2D> mesurables) 
            => mesurables.Sum(m => m.Area);
    }
}
