using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            APlateFactory factory = new DecoratedPlateFactory();
            AFlatPlate decoratedFlatPlate = factory.CreateFlatPlate();
            ADeepPlate decoratedDeepPlate = factory.CreateDeepPlate();
            Console.ReadLine();
        }
    }
}
