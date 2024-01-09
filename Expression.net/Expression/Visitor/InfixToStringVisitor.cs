using Expression.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Visitor
{
    public class InfixToStringVisitor : IVisitor
    {
        private readonly StringBuilder _stringBuilder = new();
        
        public string Result { 
            get
            {
                string res = _stringBuilder.ToString();
                _stringBuilder.Clear();
                return res;
            }
        }

        public void VisitAddOperator(AddOperator addOperator)
        {
            VisitBinaryOperator(addOperator);
        }

        public void VisitDivOperator(DivOperator divOperator)
        {
            VisitBinaryOperator(divOperator);
        }

        public void VisitMulOperator(MulOperator mulOperator)
        {
            VisitBinaryOperator(mulOperator);
        }

        public void VisitNumber(Number number)
        {
            _stringBuilder.Append(number.Value);
        }

        public void VisitSubOperator(SubOperator subOperator)
        {
            VisitBinaryOperator(subOperator);
        }

        public void VisitSubUnaryOperator(SubUnaryOperator subUnaryOperator)
        {
            VisitUnaryOperator(subUnaryOperator);
        }

        public void VisitVariable(Variable variable)
        {
            _stringBuilder.Append(variable.Name);
        }

        private void VisitBinaryOperator(AbstractBinaryOperator binaryOperator)
        {
            binaryOperator.LeftOperand.Accept(this);
            _stringBuilder.Append(' ');
            binaryOperator.RightOperand.Accept(this);
            _stringBuilder.Append(' ');
            _stringBuilder.Append(binaryOperator.ToString());
        }

        private void VisitUnaryOperator(AbstractUnaryOperator unaryOperator)
        {
            unaryOperator.Operand.Accept(this);
            _stringBuilder.Append(' ');
            _stringBuilder.Append(unaryOperator.ToString());
        }
    }
}
