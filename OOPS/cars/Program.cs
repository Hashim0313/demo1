using cars.Models;

public class Program
{
    public static void Main(string[] args)
    {

        Car car1 = new Car("Toyota", "Innova", "silver", 6000);

        Car car2 = new Car("volkswagen", "polo", "white", 4000);



        Console.WriteLine($"{car1.Make} {car1.Model} color {car1.Color} price per day: {car1.PricePerDay}\n");

        Console.WriteLine($"{car2.Make} {car2.Model} color {car2.Color} price per day: {car2.PricePerDay}\n\n");



        car1.RentCar();
        Console.Write("\n");
        car1.RentCar();
        Console.Write("\n");
        car1.ReturnCar();
        Console.Write("\n");
        Console.WriteLine("\n");

        car2.RentCar();
        Console.Write("\n");
        car2.ReturnCar();



    }
}