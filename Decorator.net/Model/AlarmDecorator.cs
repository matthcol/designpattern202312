using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.net.Model
{
    internal class AlarmDecorator : AbstractPaintDecorator
    {
        // TODO: add alarm specific operations

        public override string Visual()
        {
            return string.Format("Alarm[{0}]",          
               DecoratedPaint.Visual()
           );
        }
    }
}
