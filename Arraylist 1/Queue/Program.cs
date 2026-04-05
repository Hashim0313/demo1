using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue Q1 = new Queue();

        Q1.Enqueue("person 1");
        Q1.Enqueue("person 2");
        Q1.Enqueue("person 3");
        Q1.Enqueue("person 4");

        Console.WriteLine("persons in the queue: "+ Q1.Count);


        Console.WriteLine("next in the queue:"+Q1.Peek());

        Console.WriteLine(Q1.Dequeue()+" is being served");
        Console.WriteLine(Q1.Dequeue()+" is being served");

        Console.WriteLine("remaining in queue : "+Q1.Count);
        Console.WriteLine("next in the queue:" + Q1.Peek());
        Console.ReadLine();

    }
}