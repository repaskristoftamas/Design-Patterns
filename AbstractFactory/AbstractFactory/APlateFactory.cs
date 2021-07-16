using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class APlateFactory
    {
        public abstract AFlatPlate CreateFlatPlate();
        public abstract ADeepPlate CreateDeepPlate();
    }
}
