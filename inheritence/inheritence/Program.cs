using inheritence.models;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("tesla", "model s", "250", 4);

        car.DisplayInfo();

        Console.WriteLine();


        Bike bike = new Bike("Yamaha", "yzf r15", "150", true);

        bike.DisplayInfo();


        Console.WriteLine();


        Truck truck = new Truck("Volvo", "FH16", "120", 30);

        truck.DisplayInfo();




    }
}