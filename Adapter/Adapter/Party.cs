using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    abstract class Party
    {
        //private string name;
        public abstract string Name { get; }
        //private int partyMemberCount;
        public abstract int PartyMemberCount { get; }
    }
}
