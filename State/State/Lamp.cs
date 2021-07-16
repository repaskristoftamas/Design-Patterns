using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Lamp
    {
        private ColorState colorState;
        public ColorState ColorState { get => colorState; set => colorState = value; }
        public Lamp(ColorState colorState) { ColorState = colorState; }

        public void ColorChange() { colorState.ColorChange(this); }
    }
}
