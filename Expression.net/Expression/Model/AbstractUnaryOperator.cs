using Expression.Visitor;
using System.Collections;

namespace Expression.Model
{
    public abstract class AbstractUnaryOperator : IOperator
    {
        public IArithmeticExpression Operand { get; set; }

        public abstract void Accept(IVisitor visitor);
        public IEnumerator<IArithmeticExpression> GetEnumerator()
        {
            yield return Operand;   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}