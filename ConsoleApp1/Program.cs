using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new AdditionStrategy());

            Console.WriteLine("Execute Addition");
            int result = calculator.ExecuteCalculation(4, 2);
            Console.WriteLine(result);

            Console.WriteLine("Execute substraction");
            calculator.SetStrategy(new SubtractionStrategy());
            Console.WriteLine(calculator.ExecuteCalculation(4, 3));

            Console.WriteLine("--------------------------------------");

            IList<Item> items = new List<Item>() { new Item ("Headphone", 20), new Item("Monitor", 70) };
            ECommerce eCommerce = new ECommerce(new FiftyPercentDiscountStrategy());
            Console.WriteLine("FiftyPercentDiscountStrategy");
            Console.WriteLine(eCommerce.applyTotalDiscount(items));

            Console.WriteLine("FirstItemDiscountStrategy");
            eCommerce.SetStrategy(new FirstItemDiscountStrategy());
            Console.WriteLine(eCommerce.applyTotalDiscount(items));

            // Open a new account
            var account = new Account("Jim Johnson");
            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            Console.WriteLine("Local time zone: {0}\n", TimeZoneInfo.Local.DisplayName);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
        }
    }
}