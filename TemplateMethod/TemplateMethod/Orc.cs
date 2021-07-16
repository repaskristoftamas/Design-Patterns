using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Orc
    {
        protected Random rnd = new Random();
        protected string moral;
        public string Moral { get => moral; }
        protected AArmor armor;
        public AArmor Armor { get => armor; }
        protected AWeapon weapon;
        public AWeapon Weapon { get => weapon; }

        public void ArmingOrc()
        {
            AddLoktarOgar();
            AddArmor();
            AddWeapon();
            AddHeadArmor();
        }

        private void AddLoktarOgar()
        {
            moral = "Lok'tar ogar!!!";
        }
        protected abstract void AddArmor();
        protected abstract void AddWeapon();
        protected virtual void AddHeadArmor() { }
    }
}
