using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    static class ExtensionMethods
    {
        public static void Accept(this List<int> list, Visitor visitor)
        {
            visitor.VisitList(list);
        }
    }
}
