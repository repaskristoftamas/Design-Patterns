using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.ArmingOrc();
            Console.WriteLine("Warrior:");
            Console.WriteLine($"Moral = {warrior.Moral}");
            Console.WriteLine($"Armor durability = {warrior.Armor.Durability}");
            Console.WriteLine($"Armor item level = {warrior.Armor.ItemLevel}");
            Console.WriteLine($"Weapon durability = {warrior.Weapon.Durability}");
            Console.WriteLine($"Weapon item level = {warrior.Weapon.ItemLevel}");
            Console.WriteLine($"Head Armor durability = {warrior.HeadArmor.Durability}");
            Console.WriteLine($"Head Armor item level = {warrior.HeadArmor.ItemLevel}");
            Console.ReadLine();
        }
    }
}
