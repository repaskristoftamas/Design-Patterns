using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TVs created by Produce() haven't got any reference type, therefore shallow and deep copy cause the same result: " +
                "instances are independent from each other. If we modify one, only that one will affect.");
            Console.WriteLine("TVs created by Sale() have got reference type (Owner). In the case of shallow copy, instances are not fully independent from each otrher. " +
                "If we modify one, all will affect. In the case of deep copy, instances are fully independent from each other. If we modify one, only that one will affect.");
            Console.WriteLine("Lesson: if the prototype object has got reference type, definitely use deep copy.");
            
            LGOLEDTV tv1 = new A1("A1", 55, 350000, false);
            Factory factory = new Factory();
            LGOLEDTV[] a1s = factory.Produce(tv1, 3);
            Console.WriteLine("Shallow copy (Produce()):");
            foreach (LGOLEDTV tv in a1s)
            {
                Console.WriteLine(tv.Name);
                Console.WriteLine(tv.Size);
                Console.WriteLine(tv.Price);
                Console.WriteLine(tv.OnSale);
                Console.WriteLine("\n");
            }
            a1s[0].OnSale = true;
            a1s[0].Price -= 80000;
            Console.WriteLine("After modification:");
            foreach (LGOLEDTV tv in a1s)
            {
                Console.WriteLine(tv.Name);
                Console.WriteLine(tv.Size);
                Console.WriteLine(tv.Price);
                Console.WriteLine(tv.OnSale);
                Console.WriteLine("\n");
            }


            Owner owner = new Owner("János", 33, UseCase.PlayStation5);
            LGOLEDTV tv2 = new C1("C1", 77, owner);
            LGOLEDTV[] c1s = factory.Sale(tv2, 2);
            Console.WriteLine("Deep copy (Sale()):");
            foreach (LGOLEDTV tv in c1s)
            {
                Console.WriteLine(tv.Name);
                Console.WriteLine(tv.Size);
                Console.WriteLine(tv.Owner.Name);
                Console.WriteLine(tv.Owner.Age);
                Console.WriteLine(tv.Owner.UseCase);
                Console.WriteLine("\n");
            }
            c1s[0].Owner.Name = "Józsi";
            c1s[0].Owner.Age = 22;
            c1s[0].Owner.UseCase = UseCase.XBOX;
            Console.WriteLine("After modification:");
            foreach (LGOLEDTV tv in c1s)
            {
                Console.WriteLine(tv.Name);
                Console.WriteLine(tv.Size);
                Console.WriteLine(tv.Owner.Name);
                Console.WriteLine(tv.Owner.Age);
                Console.WriteLine(tv.Owner.UseCase);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
