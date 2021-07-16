using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class GetMax : Visitor
    {
        private int max = 0;
        public int Max => max;
        public override void VisitList(List<int> list)
        {
            foreach (int item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
        }
    }
}
