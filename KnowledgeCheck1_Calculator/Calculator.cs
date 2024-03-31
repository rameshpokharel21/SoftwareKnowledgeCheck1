namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(int first, int second)
        {
            if(second == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0.");
            }
            return (double)first / second;
        }
    }
}