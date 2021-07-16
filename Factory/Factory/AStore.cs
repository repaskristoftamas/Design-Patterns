using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class AStore
    {
        public AGreasyBread Grease()
        {
            return Create();
        }

        protected abstract AGreasyBread Create();
    }
}
