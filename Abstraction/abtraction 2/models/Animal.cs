using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abtraction_2.models
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void Eat()
        {
            Console.WriteLine("animal is  eating");
        }
    }

    internal class Cat : Animal
    {
        public override void AnimalSound()

        {
            Console.WriteLine("meow meow.....");
        }
    }

    internal class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("bow bow......");
        }
    }
}
