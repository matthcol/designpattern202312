using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    internal interface IArithmeticExpression
    {
        void Display();

        void Accept(IVisitor visitor);
    }
}
