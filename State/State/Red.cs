using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Red : ColorState
    {
        public override void ColorChange(Lamp lamp)
        {
            lamp.ColorState = new Yellow();
        }
    }
}
