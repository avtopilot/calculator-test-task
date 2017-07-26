using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.Domain.Calculation;
using Calculator.Domain.CommonType;

namespace Calculator.BusinessService.Calculation
{
    public class ExpressionCalculator : IExpressionCalculator
    {
        public Result<int> Calculate(string input)
        {
            var nodes = new Stack<BinaryExpression>();

            try
            {
                foreach (var c in ToPostFix(input))
                {
                    var s = c.ToString();
                    int n;
                    if (int.TryParse(s, out n))
                    {
                        nodes.Push(new BinaryAtomic(n));
                    }
                    else if (IsOperator(s))
                    {
                        var right = nodes.Pop();
                        var left = nodes.Pop();
                        nodes.Push(new BinaryExpression(left, right, Operators[s]));
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
                
                return new Result<int>(nodes.Pop().Value);
            }
            catch (CalculationException ex)
            {
                return new Result<int>(true, ex.Message);
            }
            catch (Exception)
            {
                return new Result<int>(true, "Error");
            }
        }

        /// <summary>
        /// Generate potfix notation
        /// </summary>
        private static string ToPostFix(string input)
        {
            var postfix = new StringBuilder();

            var ops = new Stack<string>();
            var countOfParentheses = 0;

            if(input.Split('(').Count() != input.Split(')').Count())
            {
                throw new InvalidOperationException();
            }

            foreach (var c in input)
            {
                // When we see an operator, we can pop anything
                // with higher precedence onto the infix. 
                // We do the operations with higher priority first
                var s = c.ToString();
                if (IsOperator(s))
                {
                    while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(s))
                    {
                        postfix.Append(ops.Pop());
                    }
                    ops.Push(s);
                }
                else
                {
                    switch (s)
                    {
                        case "(":
                            ops.Push(s);
                            countOfParentheses ++;
                            if (countOfParentheses > 1)
                            {
                                throw new CalculationException("Sorry, this is too complex");
                            }
                            break;

                        case ")":
                            var top = ops.Pop();
                            countOfParentheses--;
                            while (top != "(")
                            {
                                postfix.Append(top);
                                top = ops.Pop();
                            }
                            break;
                        default:
                            postfix.Append(s); // operands always go onto the infix 
                            break;
                    }
                }
            }

            while (ops.Count > 0)
                postfix.Append(ops.Pop());
            return postfix.ToString();
        }

        private static bool IsOperator(string op)
        {
            return Operators.Keys.Contains(op);
        }

        private static int Precedence(string op)
        {
            switch (op)
            {
                case "-":
                case "+":
                    return 1;
                case "*":
                case "/":
                    return 2;
            }
            return 0;
        }

        private static readonly Dictionary<string, Operator> Operators = new Dictionary<string, Operator>
        {
            {"+", (x, y) => x + y},
            {"-", (x, y) => x - y},
            {"*", (x, y) => x * y},
            {"/", (x, y) => x / y},
        };
    }
}