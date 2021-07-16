using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class NGO
    {
        private string name;
        public string Name { get => name; }
        private int ngoMemberCount;
        public int NgoMemberCount { get => ngoMemberCount; }

        public NGO(string name, int ngoMemberCount)
        {
            this.name = name;
            this.ngoMemberCount = ngoMemberCount;
        }
    }
}
