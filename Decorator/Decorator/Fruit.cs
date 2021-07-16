using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Fruit
    {
        protected string name;
        public abstract string Name { get; }
        protected double weight;
        public abstract double Weight { get; }
        protected double price;
        public abstract double Price { get; }

        public Fruit() { }
        public Fruit(string name, double weight, double price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }
    }
}
