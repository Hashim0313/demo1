using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence.models
{
    public class vehicle
    {
        public string Brand;
        public string Model;
        public string Speed;

        public vehicle(string brand, string model, string speed)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
        }

        public virtual void DisplayInfo()
        {

            Console.WriteLine($"Brand : {Brand}, Model : {Model}, Speed : {Speed} Km/h ");

        }
    }


    public class Car : vehicle
    {
        public int NumberOfDoors;

        public Car(string brand, string model, string speed, int numberofdoors)
            : base(brand, model, speed)
        {
            NumberOfDoors = numberofdoors;
        }

        public override void DisplayInfo()
        {

            base.DisplayInfo();
            Console.WriteLine($"Number of Doors : {NumberOfDoors}");
        }
    }

    public class Bike : vehicle
    {
        public bool HasCarrier;

        public Bike(string brand, string model, string speed, bool hasCarrier)
            : base(brand, model, speed)
        {
            HasCarrier = hasCarrier;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier : {HasCarrier}");
        }

    }


    public class Truck : vehicle
    {
        public int LoadCapacity;

        public Truck(string brand, string model, string speed, int loadCapacity)
            : base(brand, model, speed)
        {
            LoadCapacity = loadCapacity;

        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Load capacity : {LoadCapacity}");
        }
    }
}


















