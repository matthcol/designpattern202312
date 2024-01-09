using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    public interface IArithmeticExpression
    {
        void Accept(IVisitor visitor);
    }
}
