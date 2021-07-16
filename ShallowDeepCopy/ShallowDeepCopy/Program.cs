using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Human original = new Human("János", 64);
            Human h2 = new Human("Béla", 65);
            Human h3 = new Human("Péter", 33);
            Human[] friends = new Human[] { h2, h3 };
            original.Friends = friends;

            Human shallowCloneV1 = original.ShallowCopy();
            Human shallowCloneV2 = original.ShallowCopy2();
            Human deepClone = original.DeepCopy();

            Console.WriteLine($"Original: {original.Name}'s friends are {original.Friends[0].Name} and {original.Friends[1].Name}. " +
                              $"They are {original.Friends[0].Age} and {original.Friends[1].Age} years old.");
            Console.WriteLine($"ShallowCloneV1: {shallowCloneV1.Name}'s friends are {shallowCloneV1.Friends[0].Name} and {shallowCloneV1.Friends[1].Name}. " +
                              $"They are {shallowCloneV1.Friends[0].Age} and {shallowCloneV1.Friends[1].Age} years old.");
            Console.WriteLine($"ShallowCloneV2: {shallowCloneV2.Name}'s friends are {shallowCloneV2.Friends[0].Name} and {shallowCloneV2.Friends[1].Name}. " +
                              $"They are {shallowCloneV2.Friends[0].Age} and {shallowCloneV2.Friends[1].Age} years old.");
            Console.WriteLine($"DeepClone: {deepClone.Name}'s friends are {deepClone.Friends[0].Name} and {deepClone.Friends[1].Name}. " +
                              $"They are {deepClone.Friends[0].Age} and {deepClone.Friends[1].Age} years old.");


            original.Friends[0].Name = "Géza"; original.Friends[0].Age = 82;
            Console.WriteLine("After modification:");


            Console.WriteLine($"Original: {original.Name}'s friends are {original.Friends[0].Name} and {original.Friends[1].Name}. " +
                              $"They are {original.Friends[0].Age} and {original.Friends[1].Age} years old.");
            Console.WriteLine($"ShallowCloneV1: {shallowCloneV1.Name}'s friends are {shallowCloneV1.Friends[0].Name} and {shallowCloneV1.Friends[1].Name}. " +
                              $"They are {shallowCloneV1.Friends[0].Age} and {shallowCloneV1.Friends[1].Age} years old.");
            Console.WriteLine($"ShallowCloneV2: {shallowCloneV2.Name}'s friends are {shallowCloneV2.Friends[0].Name} and {shallowCloneV2.Friends[1].Name}. " +
                              $"They are {shallowCloneV2.Friends[0].Age} and {shallowCloneV2.Friends[1].Age} years old.");
            Console.WriteLine($"DeepClone: {deepClone.Name}'s friends are {deepClone.Friends[0].Name} and {deepClone.Friends[1].Name}. " +
                              $"They are {deepClone.Friends[0].Age} and {deepClone.Friends[1].Age} years old.");
            Console.ReadLine();
        }
    }
}
