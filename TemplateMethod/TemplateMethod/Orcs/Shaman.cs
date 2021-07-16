using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Shaman : Orc
    {
        protected override void AddArmor()
        {
            armor = new Mail(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }

        protected override void AddWeapon()
        {
            weapon = new Staff(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }
    }
}
