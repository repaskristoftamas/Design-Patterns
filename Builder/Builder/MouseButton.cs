using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class MouseButton
    {
        private readonly string position;
        public string Position => position;

        public MouseButton(string position)
        {
            this.position = position;
        }
    }
}
