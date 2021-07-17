using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            Mouse mouse = builder
                .SetName("Logitech G503")
                .SetLeftButton(new LeftButton("left"))
                .SetRightButton(new RightButton("right"))
                .SetRollerButton(new RollerButton("middle"))
                .Build();
            Console.WriteLine(mouse.Name);
            Console.WriteLine($"Left button positon is {mouse.LeftButton.Position}.");
            Console.WriteLine($"Right button position is {mouse.RightButton.Position}.");
            Console.WriteLine($"Roller button position is {mouse.RollerButton.Position}.");
            Console.ReadLine();
        }
    }
}
