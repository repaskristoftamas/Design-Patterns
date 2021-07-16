using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class GetSum : Visitor
    {
        private int sum = 0;
        public int Sum => sum;
        public override void VisitList(List<int> list)
        {
            foreach (int n in list)
            {
                sum += n;
            }
        }
    }
}
