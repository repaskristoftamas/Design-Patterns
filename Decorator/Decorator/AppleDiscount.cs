using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AppleDiscount : OnSale
    {
        public AppleDiscount(Fruit fruit) : base(fruit) { }
        private double discount;
        public double Discount { set => discount = value; }
        public override double Price
        {
            get
            {
                double price = base.price;
                double percentage = 100 - discount;
                return Math.Round((price * percentage) / 100, 3);
            }
        }
    }
}
