using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class RealBoss : Boss
    {
        public override void Request()
        {
            Console.WriteLine("Please do this and do that.");
        }
    }
}
