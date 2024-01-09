using GeometryObservable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Observer
{
    public class ConsoleLogger: IObserver<AbstractForm>
    {
        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(AbstractForm form)
        {
            Console.WriteLine($"Form {form.Name} has been updated: {form.ToString()}"); 
        }   
    }
}
