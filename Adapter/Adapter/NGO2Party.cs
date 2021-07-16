using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class NGO2Party : Party
    {
        private NGO ngo;
        public NGO2Party(NGO ngo)
        {
            this.ngo = ngo;
        }

        public override string Name { get => ngo.Name; }
        public override int PartyMemberCount { get => ngo.NgoMemberCount; }
    }
}
