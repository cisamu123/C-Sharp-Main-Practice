using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int price = 1;
            int price2 = 10;
            Console.WriteLine("enter the amount of money");
            money = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Hello! You have a " + money + "$ Buy an e-book that costs" + price + "$?");
            int result = money - price;
            if (result >= price)
                Console.WriteLine($"Bought!");
            else
                Console.WriteLine($"Insufficient funds!");
            Console.ReadLine();
            Console.WriteLine("You have left " + result + "$" );
            Console.WriteLine("Buy a T-shirt for" + price2 + "$?");
                   if (result >= price2)
                Console.WriteLine($"Bought!");
            else
                Console.WriteLine($"Insufficient funds!"); 
            Console.ReadLine();
            int result2 = money - price2;
            Console.WriteLine("You have left " + result2 + "$");
        }
    }
}
