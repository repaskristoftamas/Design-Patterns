using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class LoudSneezeStrategy : SneezeStrategy
    {
        public override void Sneezing()
        {
            Console.WriteLine("He sneezes loudly.");
        }
    }
}
