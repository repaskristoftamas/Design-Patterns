using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AWeapon
    {
        protected double durability;
        public double Durability { get => durability; }
        protected int itemLevel;
        public int ItemLevel { get => itemLevel; }
    }
}
