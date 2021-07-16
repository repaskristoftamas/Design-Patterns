using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Hunter : Orc
    {
        protected override void AddArmor()
        {
            armor = new Leather(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }

        protected override void AddWeapon()
        {
            weapon = new Gun(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }
    }
}
