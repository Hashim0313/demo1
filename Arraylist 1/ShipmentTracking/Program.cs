using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList TrackingNumber = new ArrayList();

        TrackingNumber.Add("cargo 1");
        TrackingNumber.Add("cargo 2");
        TrackingNumber.Add("cargo 3");
        TrackingNumber.Add("cargo 4");
       


        Hashtable Shipment = new Hashtable();

        Shipment["cargo 1"] = "sender : john snow, receiver : daenerys, status : delivered";
        Shipment["cargo 2"] = "sender : arya , receiver : sansa, status : in transit";
        Shipment["cargo 3"] = "sender : tyrion , receiver : jaime, status : out for delivery";
        Shipment["cargo 4"] = "sender : peter , receiver : joffrey, status : pending";
        Console.WriteLine("Total number of shipments: " + TrackingNumber.Count);


        SortedList Shipmentdelivery = new SortedList();
        Shipmentdelivery.Add(DateTime.Parse("2024-06-01"), "cargo 1");
        Shipmentdelivery.Add(DateTime.Parse("2024-06-03"), "cargo 2");
        Shipmentdelivery.Add(DateTime.Parse("2024-06-02"), "cargo 3");
        Shipmentdelivery.Add(DateTime.Parse("2024-06-05"), "cargo 4");





        Queue ShipmentQueue = new Queue();
        ShipmentQueue.Enqueue("cargo 1");
        ShipmentQueue.Enqueue("cargo 2");
        ShipmentQueue.Enqueue("cargo 3");   
        ShipmentQueue.Enqueue("cargo 4");

        Console.WriteLine("First shipment to be delivered: " + ShipmentQueue.Dequeue());


        Stack ShipmentStack = new Stack();
        ShipmentStack.Push("cargo 1 cancelled");
        ShipmentStack.Push("cargo 2 Rescheduled ");
        ShipmentStack.Push("cargo 3 cancelled");
        ShipmentStack.Push("cargo 4 Rescheduled ");


    }
}