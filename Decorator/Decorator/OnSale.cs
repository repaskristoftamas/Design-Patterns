using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class OnSale : Fruit
    {
        private Fruit fruit;
        public Fruit Fruit => fruit;
        public override string Name => name;
        public override double Weight => weight;
        public override double Price => price;

        public OnSale(Fruit fruit) { this.fruit = fruit; }
    }
}
