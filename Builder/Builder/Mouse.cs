using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Mouse
    {
        private string name;
        public string Name { get => name; set => name = value; }
        private MouseButton leftButton;
        public MouseButton LeftButton { get => leftButton; set => leftButton = value; }
        private MouseButton rightButton;
        public MouseButton RightButton { get => rightButton; set => rightButton = value; }
        private MouseButton rollerButton;
        public MouseButton RollerButton { get => rollerButton; set => rollerButton = value; }
    }
}
