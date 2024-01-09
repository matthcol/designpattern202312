using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.GeneralObserver
{
    public abstract class AbstractSubject<T>: IObservable<T>, IDisposable
    {
        private Stack<IObserver<T>> _observers = new();

        public virtual void Dispose()
        {
            Console.WriteLine($"TRACE: dispose as Abstract Subject <{this}>");
            _observers.Pop();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            _observers.Push(observer);
            return this;
        }

        protected void NotifyAll(T value)
        {
            foreach(var observer in _observers) {
                observer.OnNext(value);
            }
        }
    }
}
