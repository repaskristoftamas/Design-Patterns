using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Watermelon : Fruit
    {
        public override string Name => name;
        public override double Weight => weight;
        public override double Price => price;

        public Watermelon(string name, double weight, double price)
    : base(name, weight, price) { }
    }
}
