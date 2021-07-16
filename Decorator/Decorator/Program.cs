using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Apple("apple", 10.5, 8.7);
            Console.WriteLine(apple.Price);
            AppleDiscount appleDiscount = new AppleDiscount(apple);
            appleDiscount.Discount = 20;
            Console.WriteLine(appleDiscount.Price);
            Console.ReadLine();
        }
    }
}
