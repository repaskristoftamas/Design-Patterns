using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Sneeze sneeze = new Sneeze();
            sneeze.SetStrategy(new FunnySneezeStrategy());
            sneeze.Sneezing();
            sneeze.SetStrategy(new LoudSneezeStrategy());
            sneeze.Sneezing();
            sneeze.SetStrategy(new UnstoppableSneezeStrategy());
            sneeze.Sneezing();
            Console.ReadLine();
        }
    }
}
