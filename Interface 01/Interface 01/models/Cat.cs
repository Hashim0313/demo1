using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_01.models
{
    internal class Cat : IAnimal,IPrice
    {
        public void AnimalSound()
        {
            Console.WriteLine("cat meows");
        }

        public void AnimalPrice()
        {
            Console.WriteLine("price for cat.......$$$$");
        }
    }
}
