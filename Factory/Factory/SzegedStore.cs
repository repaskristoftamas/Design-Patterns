using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class SzegedStore : AStore
    {
        protected override AGreasyBread Create()
        {
            AGreasyBread bread = new GreasyBreadSzeged(BreadType.wholegrain, 1.7, FatType.goose, 14.2, 2.8, OnionType.purple, 8.9);
            return bread;
        }
    }
}
