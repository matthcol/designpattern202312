using Expression.Visitor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    public abstract class AbstractBinaryOperator: IOperator
    {
        public IArithmeticExpression LeftOperand { get; set; }
        public IArithmeticExpression RightOperand { get; set; }

        public abstract void Accept(IVisitor visitor);

        public IEnumerator<IArithmeticExpression> GetEnumerator()
        {
            yield return LeftOperand;
            yield return RightOperand;  
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
