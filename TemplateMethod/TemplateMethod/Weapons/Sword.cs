using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Sword : AWeapon
    {
        public Sword(double durability, int itemLevel)
        {
            this.durability = durability;
            this.itemLevel = itemLevel;
        }
    }
}
