using GeometryObservable.GeneralObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.Model
{
    public class AbstractForm(String name): AbstractSubject
    {
        private String _name = name;
        public String Name { 
            get => _name; 
            set {
                _name = value;
                NotifyAll();
            } 
        }
    }
}
