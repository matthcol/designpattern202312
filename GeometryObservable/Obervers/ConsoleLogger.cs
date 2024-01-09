using GeometryObservable.GeneralObserver;
using GeometryObservable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.Obervers
{
    public class ConsoleLogger(AbstractForm abstractForm) : IObserver
    {
        public AbstractForm Form { get; set; } = abstractForm;

        public void Updated()
        {
            Console.WriteLine($"Form {Form.Name} has been updated: {Form.ToString()}");
        }
    }
}
