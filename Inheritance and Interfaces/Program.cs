using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interfaces
{
    interface IAnimal
    {
        void Speak();
    }

    interface IHealth
    {
        float Health { get; }
    }

    class LivingAnimal : IAnimal, IHealth
    {
        public LivingAnimal(float health)
        {
            Health = health;
        }

        public void Speak()
        {
            Console.WriteLine("I have {0} health.", Health);
        }

        public float Health
        {
            get;
            private set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started!");

            IAnimal a = new LivingAnimal(10.43f);
            a.Speak();

            Console.ReadKey();
        }
    }
}
