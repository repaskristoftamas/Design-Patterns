using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class GreasyBreadSzeged : AGreasyBread
    {
        public GreasyBreadSzeged(BreadType breadType, double breadThickness, FatType fatType, double fatQuantity, double saltQuantity, OnionType onionType, double onionQuantity)
                : base(breadType, breadThickness, fatType, fatQuantity, saltQuantity, onionType, onionQuantity) { }
    }
}
