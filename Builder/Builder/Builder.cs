using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Builder
    {
        private readonly Mouse mouse = new Mouse();
        public Builder SetName(string name)
        {
            mouse.Name = name;
            return this;
        }
        public Builder SetLeftButton(MouseButton button)
        {
            mouse.LeftButton = button;
            return this;
        }
        public Builder SetRightButton(MouseButton button)
        {
            mouse.RightButton = button;
            return this;
        }
        public Builder SetRollerButton(MouseButton button)
        {
            mouse.RollerButton = button;
            return this;
        }

        public Mouse Build() { return mouse; }
    }
}
