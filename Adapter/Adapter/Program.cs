using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            NGO ngo = new NGO("NGO", 1000);
            Console.WriteLine($"Name: {ngo.Name}, Member count: {ngo.NgoMemberCount}");
            Party party = new NGO2Party(ngo);
            Console.WriteLine($"Name: {party.Name}, Member count: {party.PartyMemberCount}");
            Console.ReadLine();
        }
    }
}
