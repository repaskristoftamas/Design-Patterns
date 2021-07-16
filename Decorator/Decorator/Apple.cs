using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Apple : Fruit
    {
        public override string Name => name;
        public override double Weight => weight;
        public override double Price => price;

        public Apple(string name, double weight, double price)
            :base(name, weight, price) { }
    }
}
