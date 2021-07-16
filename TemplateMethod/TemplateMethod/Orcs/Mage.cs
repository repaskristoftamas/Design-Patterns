using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Mage : Orc
    {
        protected override void AddArmor()
        {
            armor = new Cloth(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }

        protected override void AddWeapon()
        {
            weapon = new Staff(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }
    }
}
