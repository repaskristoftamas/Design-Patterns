using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Warrior : Orc
    {
        protected AArmor headArmor;
        public HeadArmor HeadArmor { get => (HeadArmor)headArmor; }

        protected override void AddArmor()
        {
            armor = new Plate(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }

        protected override void AddWeapon()
        {
            weapon = new Sword(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }

        protected override void AddHeadArmor()
        {
            headArmor = new HeadArmor(rnd.NextDouble() * 100, rnd.Next(1, 100));
        }
    }
}
