namespace _03.DependencyInversion.Models
{
    using Contracts;

    public class DivisionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
