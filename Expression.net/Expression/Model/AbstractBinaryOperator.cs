using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    internal abstract class AbstractBinaryOperator: IOperator
    {
        public IArithmeticExpression LeftOperand { get; set; }
        public IArithmeticExpression RightOperand { get; set; }

        public abstract void Accept(IVisitor visitor);
        public abstract void Display();
    }
}
