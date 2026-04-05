using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_01.models
{
    internal class Dog : IAnimal,IPrice
    {
        public void AnimalSound()
        {
            Console.WriteLine("Dog Barks");
        }

        public void AnimalPrice()
        {
            Console.WriteLine("price for dog......$$$$");
        }
    }
}
