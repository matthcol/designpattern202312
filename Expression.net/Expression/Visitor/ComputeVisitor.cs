using Expression.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Visitor
{
    public class ComputeVisitor : IVisitor
    {
        public IDictionary<Variable, double> VariableValues { get; set; } = new Dictionary<Variable, double>();
        
        public double Result { get; set; }
        
        public void VisitAddOperator(AddOperator addOperator)
        {
            addOperator.RightOperand.Accept(this);
            double right = Result;
            addOperator.LeftOperand.Accept(this);
            Result += right; 
        }

        public void VisitDivOperator(DivOperator divOperator)
        {
            divOperator.RightOperand.Accept(this);
            double right = Result;
            divOperator.LeftOperand.Accept(this);
            Result /= right;
        }

        public void VisitMulOperator(MulOperator mulOperator)
        {
            mulOperator.RightOperand.Accept(this);
            double right = Result;
            mulOperator.LeftOperand.Accept(this);
            Result *= right;
        }

        public void VisitNumber(Number number)
        {
            Result = number.Value;
        }

        public void VisitSubOperator(SubOperator subOperator)
        {
            subOperator.RightOperand.Accept(this);
            double right = Result;
            subOperator.LeftOperand.Accept(this);
            Result -= right;
        }

        public void VisitSubUnaryOperator(SubUnaryOperator subUnaryOperator)
        {
            subUnaryOperator.Operand.Accept(this);
            Result *= -1;
        }

        public void VisitVariable(Variable variable)
        {
            Result = VariableValues[variable];
        }
    }
}
