using Geometry.Model;
using GeometryObservable.GeneralObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.Observers
{
    public class AreaPaintCounter: IObserver<double>
    {
        public double TotalArea { get; private set; } = 0.0;

        public void OnCompleted()
        {
           
        }

        public void OnError(Exception error)
        {
          
        }

        public void OnNext(double area)
        {
            TotalArea += area;
        }

    }
}
