using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interfaces
{
    abstract class Animal
    {
        public abstract void Speak();
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog");
        }
    }
    
    class Pitbull : Dog
    {
        public override void Speak()
        {
            Console.WriteLine("Pitbull");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started!");

            Animal a = new Dog();
            a.Speak();

            Console.ReadKey();
        }
    }
}
