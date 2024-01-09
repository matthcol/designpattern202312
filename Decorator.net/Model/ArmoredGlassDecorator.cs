using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.net.Model
{
    internal class ArmoredGlassDecorator : AbstractPaintDecorator
    {
        public override string Visual()
        {
            return string.Format("ArmoredGlass[{0}]",          
               DecoratedPaint.Visual()
           );
        }
    }
}
