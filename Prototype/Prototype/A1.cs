using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class A1 : LGOLEDTV
    {
        public A1() { }
        public A1(string name, int size, int price, bool onSale)
            :base(name, size, price, onSale) { }
        public A1(string name, int size, Owner owner)
            : base(name, size, owner) { }
        public override LGOLEDTV DeepCopy()
        {
            LGOLEDTV clone = new A1(Name, Size, Owner);
            return clone;
        }
    }
}
