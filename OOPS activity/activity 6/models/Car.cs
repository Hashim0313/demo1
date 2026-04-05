using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_6.models
{
    internal class Car
    {

        public int Id;
        public string Brand;
        public int Mileage;




        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Id: {Id}\n Brand: {Brand}\n Mileage: {Mileage}\n");
        }



        public Car(int id, string brand, int mileage)
        {
            Id = id;
            Brand = brand;
            Mileage = mileage;
        }


    }
}
