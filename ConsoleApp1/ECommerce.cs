using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Strategy
    public interface IDiscountStrategy
    {
        float CalculateTotalDiscount(IList<Item> items);
    }

    public struct Item 
    {
        public Item (string name, float price)
        {  Name = name; Price = price; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
    // ConcreteStrategy
    // Sum of all items price then divide by 2
    public class FiftyPercentDiscountStrategy : IDiscountStrategy
    {
        public float CalculateTotalDiscount(IList<Item> items)
        {
            return items.Sum(item => item.Price) / 2;
        }
    }
    public class FirstItemDiscountStrategy : IDiscountStrategy
    {
        public float CalculateTotalDiscount(IList<Item> items)
        {
            return items.Sum(item => item.Price) - (items.First().Price / 2);
        }
    }
    // Context
    public class ECommerce
    {
        private IDiscountStrategy _strategy;
        public ECommerce(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public float applyTotalDiscount(IList<Item> items)
        {
            return _strategy.CalculateTotalDiscount(items);
        }
    }
}
