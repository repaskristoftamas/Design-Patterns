using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class DecoratedPlateFactory : APlateFactory
    {
        public override ADeepPlate CreateDeepPlate()
        {
            return new DecoratedDeepPlate();
        }

        public override AFlatPlate CreateFlatPlate()
        {
            return new DecoratedFlatPlate();
        }
    }
}
