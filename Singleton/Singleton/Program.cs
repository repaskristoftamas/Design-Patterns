using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            God god = God.GetInstance();
            God anotherGod = God.GetInstance();
            if (god == anotherGod)
            {
                Console.WriteLine("The references are the same, there is only one instance of god.");
            }
            Console.ReadLine();
        }
    }
}
