using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class EgerStore : AStore
    {
        protected override AGreasyBread Create()
        {
            AGreasyBread bread = new GreasyBreadEger(BreadType.white, 2.8, FatType.pig, 15.2, 3.5, OnionType.red, 10.5);
            return bread;
        }
    }
}
