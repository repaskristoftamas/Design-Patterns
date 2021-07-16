using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class C1 : LGOLEDTV
    {
        public C1() { }
        public C1(string name, int size, int price, bool onSale)
            : base(name, size, price, onSale) { }
        public C1(string name, int size, Owner owner)
            : base(name, size, owner) { }
        public override LGOLEDTV DeepCopy()
        {
            LGOLEDTV clone = new C1
            {
                Name = Name,
                Size = Size,
                Owner = Owner.DeepCopy()
            };
            return clone;
        }
    }
}
