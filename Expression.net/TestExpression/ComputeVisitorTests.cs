using Expression.Model;
using Expression.Visitor;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExpression
{
    public class ComputeVisitorTests
    {
        private readonly ComputeVisitor _computeVisitor;

        public ComputeVisitorTests()
        {
            _computeVisitor = new();
        }


        [Fact]
        public void VisitNumberTest()
        {
            double value = 15.75;
            IArithmeticExpression expr = new Number() { Value = value };
            expr.Accept(_computeVisitor);
            Assert.Equal(value, _computeVisitor.Result);
        }

        [Fact]
        public void VisitVariableHasValueTest()
        {
            Variable variable = new()
            {
                Name = "x_0"
            };
            double value = 23.625;
            _computeVisitor.VariableValues = new Dictionary<Variable,double>()
            {
                { variable, value}
            };
            IArithmeticExpression expr = variable;
            expr.Accept(_computeVisitor);
            Assert.Equal(value, _computeVisitor.Result);
        }

        [Fact]
        public void VisitVariableHasNoValueTest()
        {
            IArithmeticExpression expr = new Variable()
            {
                Name = "x_0"
            };
            Assert.Throws<KeyNotFoundException>(() => expr.Accept(_computeVisitor));
        }

        [Fact]
        public void VisitSubUnaryOperatorTest()
        {
            var operand = Mock.Of<IArithmeticExpression>();        
            Mock.Get(operand)
                .Setup(op => op.Accept(It.IsAny<IVisitor>()))
                .Callback(() => _computeVisitor.Result = 15.25);
          

            IArithmeticExpression expr = new SubUnaryOperator()
            {
                Operand = operand
            };
            expr.Accept(_computeVisitor);
            Assert.Equal(-15.25, _computeVisitor.Result);
        }

        [Fact]
        public void VisitAddOperatorTest()
        {
            var left = Mock.Of<IArithmeticExpression>();
            var right = Mock.Of<IArithmeticExpression>();
            Mock.Get(left)
                .Setup(op => op.Accept(It.IsAny<IVisitor>()))
                .Callback(() => _computeVisitor.Result = 15.25);
            Mock.Get(right)
                .Setup(op => op.Accept(It.IsAny<IVisitor>()))
                .Callback(() => _computeVisitor.Result = 2.75);

            IArithmeticExpression expr = new AddOperator()
            {
                LeftOperand = left,
                RightOperand = right
            };
            expr.Accept(_computeVisitor);
            Assert.Equal(18.0, _computeVisitor.Result);
        }

        // same test as previous one,factorized for all binary operators

        public static IEnumerable<object[]> VisitBinaryOperatorTestArgsGenerator()
        {
            yield return new object[] { new AddOperator(), 2.75, 1.25, 4.0 };
            yield return new object[] { new SubOperator(), 2.75, 1.25, 1.5 };
            yield return new object[] { new MulOperator(), 0.5, 12.5, 6.25 };
            yield return new object[] { new DivOperator(), 12.0, 4.0, 3.0 };
        }

        [Theory]
        [MemberData(nameof(VisitBinaryOperatorTestArgsGenerator))]
        public void VisitBinaryOperatorTest(
            AbstractBinaryOperator binaryOperator, 
            double leftValue, 
            double rightValue, 
            double expectedValue
        )
        {
            var left = Mock.Of<IArithmeticExpression>();
            var right = Mock.Of<IArithmeticExpression>();
            Mock.Get(left)
                .Setup(op => op.Accept(It.IsAny<IVisitor>()))
                .Callback(() => _computeVisitor.Result = leftValue);
            Mock.Get(right)
                .Setup(op => op.Accept(It.IsAny<IVisitor>()))
                .Callback(() => _computeVisitor.Result = rightValue);
            binaryOperator.LeftOperand = left;
            binaryOperator.RightOperand = right;
            IArithmeticExpression expr = binaryOperator;
            expr.Accept(_computeVisitor);
            Assert.Equal(expectedValue, _computeVisitor.Result);
        }
    }
}
