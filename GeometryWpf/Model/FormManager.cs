using GeometryObservable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model
{
    internal class FormManager: IObservable<AbstractForm>, IDisposable
    {

        private IList<AbstractForm> _forms = new List<AbstractForm>();
        private Stack<IObserver<AbstractForm>> _observerStack = new Stack<IObserver<AbstractForm>>();

        // receiver command OnClickAddCircle
        public void AddCircle(String name, int x, int y, int radius)
        {
            var circle = new Circle(name, new Point("?", x, y), radius);
            _forms.Add(circle);
            NotifyAll(circle);
        }

        // receiver command OnClickAddPoint
        public void AddPoint(String name, int x, int y)
        {
            var point = new Point(name, x, y);
            _forms.Add(point);
            NotifyAll(point);
        }

        public void Dispose()
        {
            _observerStack.Pop();
        }

        public IDisposable Subscribe(IObserver<AbstractForm> observer)
        {
            _observerStack.Push(observer);
            return this;
        }

        private void NotifyAll(AbstractForm form)
        {
            foreach(var observer in _observerStack)
            {
                observer.OnNext(form);
            }
        }
    }
}
