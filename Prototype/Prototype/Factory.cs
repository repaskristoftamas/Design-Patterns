using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Factory
    {
        public LGOLEDTV[] Produce(LGOLEDTV tv, int quantity)
        {
            LGOLEDTV[] temp = new LGOLEDTV[quantity];
            for (int i = 0; i < quantity; i++)
            {
                temp[i] = tv.ShallowCopy();
            }
            return temp;
        }
        public LGOLEDTV[] Sale(LGOLEDTV tv, int quantity)
        {
            LGOLEDTV[] temp = new LGOLEDTV[quantity];
            for (int i = 0; i < quantity; i++)
            {
                temp[i] = tv.DeepCopy();
            }
            return temp;
        }
    }
}
