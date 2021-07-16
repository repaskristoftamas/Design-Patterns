using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class UndecoratedPlateFactory : APlateFactory
    {
        public override ADeepPlate CreateDeepPlate()
        {
            return new UndecoratedDeepPlate();
        }

        public override AFlatPlate CreateFlatPlate()
        {
            return new UndecoratedFlatPlate();
        }
    }
}
