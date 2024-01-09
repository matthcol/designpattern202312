using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObservable.Model
{
    public class AbstractForm
    {
        public AbstractForm(String name)
        {
            Name = name;
        }

        public String Name {
            get; set; 
        }
    }
}
