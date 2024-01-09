using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.GeneralObserver
{
    public abstract class AbstractSubject
    {
        private ISet<IObserver> _observers = new HashSet<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void NotifyAll()
        {
            foreach(var observer in _observers) {
                observer.Updated();
            }
        }
    }
}
