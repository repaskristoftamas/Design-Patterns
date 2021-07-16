using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
            GetSum visitor = new GetSum();
            list.Accept(visitor);
            Console.WriteLine($"Sum = {visitor.Sum}");
            GetMax visitor2 = new GetMax();
            list.Accept(visitor2);
            Console.WriteLine($"Max = {visitor2.Max}");
            Console.ReadLine();
        }
    }
}
