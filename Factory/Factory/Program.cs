using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AStore egerStore = new EgerStore();
            AGreasyBread egerBread = egerStore.Grease();
            Console.WriteLine($"Greasy bread in Eger is mostly created with {egerBread.BreadType} bread, which is {egerBread.BreadThickness} cm thick. " +
                              $"It's greased with {egerBread.FatType} fat, which is basically {egerBread.FatQuantity} g weight. " +
                              $"It's served with {egerBread.OnionType} onion, about {egerBread.OnionQuantity} g weight. " +
                              $"It's always served with salt on it, about {egerBread.SaltQuantity} g.");

            Console.WriteLine("\n");

            AStore szegedStore = new SzegedStore();
            AGreasyBread szegedBread = szegedStore.Grease();
            Console.WriteLine($"Greasy bread in Szeged is mostly created with {szegedBread.BreadType} bread, which is {szegedBread.BreadThickness} cm thick. " +
                  $"It's greased with {szegedBread.FatType} fat, which is basically {szegedBread.FatQuantity} g weight. " +
                  $"It's served with {szegedBread.OnionType} onion, about {szegedBread.OnionQuantity} g weight. " +
                  $"It's always served with salt on it, about {szegedBread.SaltQuantity} g.");

            Console.ReadLine();
        }
    }
}
