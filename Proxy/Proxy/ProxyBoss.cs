using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyBoss : Boss
    {
        private RealBoss realBoss;
        public override void Request()
        {
            if (realBoss == null)
            {
                realBoss = new RealBoss();
            }
            realBoss.Request();
        }
    }
}
