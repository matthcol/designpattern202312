using Expression.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Visitor
{
    public class DisplayInfixVisitor : IVisitor
    {
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
            Console.Write(number.Value);
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
            Console.Write(variable.Name);
        }

        private void VisitBinaryOperator(AbstractBinaryOperator binaryOperator)
        {
            binaryOperator.LeftOperand.Accept(this);
            Console.Write(' ');
            binaryOperator.RightOperand.Accept(this);
            Console.Write(' ');
            Console.Write(binaryOperator);
        }

        private void VisitUnaryOperator(AbstractUnaryOperator unaryOperator)
        {
            unaryOperator.Operand.Accept(this);
            Console.Write(' ');
            Console.Write(unaryOperator);
        }
    }
}
