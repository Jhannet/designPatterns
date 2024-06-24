using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Strategy
    public interface ICalculationStrategy
    {
        int Calculate(int value1, int value2);
    }

    // ConcreteStrategy
    public class AdditionStrategy : ICalculationStrategy
    {
        public int Calculate(int value1, int value2)
        {
            return value1 + value2;
        }
    }
    public class SubtractionStrategy : ICalculationStrategy
    {
        public int Calculate(int value1, int value2)
        {
            return value1 - value2;
        }
    }
    // Context
    public class Calculator
    {
        private ICalculationStrategy _strategy;
        public Calculator(ICalculationStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(ICalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteCalculation(int value1, int value2)
        {
            return _strategy.Calculate(value1, value2);
        }

    }
}
