using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp(new Red());
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            lamp.ColorChange();
            Console.WriteLine(lamp.ColorState);
            Console.ReadLine();
        }
    }
}
