using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    internal class AddOperator : AbstractBinaryOperator
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.visitAddOperator(this);
        }

        public override void Display()
        {
            LeftOperand.Display();
            Console.Write(" ");
            RightOperand.Display();
            Console.Write(" +");
        }
    }
}
