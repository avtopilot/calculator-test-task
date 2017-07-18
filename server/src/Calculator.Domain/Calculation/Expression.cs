namespace Calculator.Domain.Calculation
{
    public delegate int Operator(int x, int y);
 
    public class BinaryExpression
    {
        protected BinaryExpression()
        {
        }

        public BinaryExpression(BinaryExpression left, BinaryExpression right, Operator op)
        {
            Left = left;
            Right = right;
            Operator = op;
        }

        /// <summary>
        /// Returns the value of the tree 
        /// </summary>
        public virtual int Value
        {
            get
            {
                return Operator(Left.Value, Right.Value);
            }
            protected set { }
        }

        public BinaryExpression Left;
        public BinaryExpression Right;
        public Operator Operator;
    }

    /// <summary>
    /// Represents a leaf in BinaryExpression tree
    /// </summary>
    public class BinaryAtomic : BinaryExpression
    {
        protected BinaryAtomic()
        {
        }

        public BinaryAtomic(int value)
        {
            Value = value;
        }

        public override int Value
        {
            get;
            protected set;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}