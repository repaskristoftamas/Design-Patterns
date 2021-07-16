using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Staff : AWeapon
    {
        public Staff(double durability, int itemLevel)
        {
            this.durability = durability;
            this.itemLevel = itemLevel;
        }
    }
}
