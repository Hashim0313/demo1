using Question_1.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        
        OutPatient op1 = new OutPatient(1,"Jon");

        OutPatient op2 = new OutPatient(5, "Wick");



        InPatient ip1 = new InPatient(55, "James");

        InPatient ip2 = new InPatient(58, "Bond");



        Console.WriteLine("out patient bill : ");

        op1.CalculateBill(5);

                                                      Console.WriteLine();

        op2.CalculateBill(3);

                                                     Console.WriteLine();


        Console.WriteLine("in patient bill : ");

                                                     Console.WriteLine();

        ip1.CalculateBill(4);

                                                     Console.WriteLine();

        ip2.CalculateBill(6);

    }
}