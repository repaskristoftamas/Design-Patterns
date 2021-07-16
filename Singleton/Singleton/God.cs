using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class God
    {
        private God() { }
        private static God god = null;
        public static God GetInstance()
        {
            if (god == null)
            {
                god = new God();
            }
            return god;
        }
    }
}
