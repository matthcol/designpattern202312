using Geometry.Model;
using GeometryObservable.GeneralObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.Obervers
{
    public class CirclePaintCounter(Circle circle): IObserver
    {
        public Circle Circle { get; set; } = circle;
        public double TotalArea { get; private set; } = 0.0;

        public void Updated()
        {
            TotalArea += Circle.Surface;
        }
    }
}
