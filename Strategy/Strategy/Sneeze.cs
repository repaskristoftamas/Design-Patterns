using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Sneeze
    {
        private SneezeStrategy strategy;

        public void SetStrategy(SneezeStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Sneezing()
        {
            strategy.Sneezing();
        }
    }
}
