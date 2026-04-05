using activity_6.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car(1, "BMW", 20);
        car1.DisplayCarInfo();

        Car car2 = new Car(2, "Audi", 30);
        car2.DisplayCarInfo();
    }
}