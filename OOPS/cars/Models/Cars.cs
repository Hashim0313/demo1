using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars.Models
{
    public class Car
    {

        public string Make;
        public string Model;
        public string Color;
        public decimal PricePerDay;
        public bool IsRented;


        public Car(string make, string model, string color, decimal pricePerDay)
        {
            Make = make;
            Model = model;
            Color = color;
            PricePerDay = pricePerDay;
            IsRented = false;
        }
        public void RentCar()
        {

            if (!IsRented)
            {
                IsRented = true;
                Console.WriteLine($"The car {Make} {Model} has been rented");
            }
            else
            {
                Console.WriteLine($"the car {Make} {Model} is already rented");
            }


        }

        public void ReturnCar()

        {
            if (IsRented)
            {
                IsRented = false;
                Console.WriteLine($"the car {Make} {Model} has been returned");
            }

            else
            {
                Console.WriteLine($"the car {Make} {Model} is not returned ");
            }

        }

    }
}
