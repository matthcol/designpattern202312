using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.net.Model
{
    internal abstract class AbstractPaintDecorator : IPaint
    {
        public IPaint DecoratedPaint { get; set; }
        public abstract string Visual();
    }
}
