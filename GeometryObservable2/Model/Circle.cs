using GeometryObservable.GeneralObserver;
using GeometryObservable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model
{
    public class Circle: AbstractForm, IObservable<double>
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
                NotifyAll(this);
            }
        }
        public double Radius {
            get => _radius;
            set
            {
                _radius = value;
                // notify different kind of observers
                NotifyAll(this);
                _doubleObserver?.OnNext(_radius);
            }
        }
        public double Surface => Math.PI * Radius * Radius;
        public double Perimeter => 2 * Math.PI * Radius;

        public override string ToString() => $"{Name} <c:{Center}; r={Radius}>)";

        public IDisposable Subscribe(IObserver<double> observer)
        {
            // TODO: decide if new observer can overwrite preceding
            _doubleObserver = observer;
            return this;
        }

        public void Unsubscribe()
        {
            // base.Dispose();
            Console.WriteLine("TRACE: Unsubscribe circle observer");
            _doubleObserver = null;
        }

        private Point _center;
        private double _radius;
        private IObserver<double>? _doubleObserver = null;
    }
}
