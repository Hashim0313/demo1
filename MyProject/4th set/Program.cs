internal class Program
{
    private static void Main(string[] args)
    {

        // 2

        //Console.WriteLine("Even numbers from 1 to 100:\n");

        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.Write(i + " \n");
        //    }
        //}


        // 1


        //Console.Write("Enter a number ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"\nMultiplication table for {number}:\n");


        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"{number} x {i} = {number * i}");
        //}


        // 3


        //Console.Write("Enter a number ");
        //int n = Convert.ToInt32(Console.ReadLine());

        //int sum = 0;

        //for (int i = 1; i <= n; i++)
        //{
        //    sum += i;
        //}

        //Console.WriteLine($"\n Sum of numbers from 1 to {n} is: {sum}");


        //4

        //int rows = 4;

        //for (int i = 1; i <= rows; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}




        //5



        //string correctPassword = "admin123";
        //string input;

        //do
        //{
        //    Console.Write("Enter password: ");
        //    input = Console.ReadLine();

        //    if (input != correctPassword)
        //    {
        //        Console.WriteLine("incorrect password. \n");
        //    }

        //} while (input != correctPassword);

        //Console.WriteLine("\n welcome!");



        //6

        //Console.WriteLine("Reverse a number");
        //Console.Write("Please enter a number: ");

        //int number = Convert.ToInt32(Console.ReadLine());
        //int rev = 0;

        //while (number != 0)
        //{
        //    rev = rev * 10 + number % 10;
        //    number = number / 10;
        //}
        //Console.WriteLine($"Reversed number:{rev}");
        //Console.WriteLine("\n");







        //do while

        //1

        do
        {
            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose operation (+ or -): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double results;

            if (operation == '+')
            {
                results = number1 + number2;
                Console.WriteLine("Result: " + results);
            }
            else if (operation == '-')
            {
                results = number1 - number2;
                Console.WriteLine("Result: " + results);
            }
            else
            {
                Console.WriteLine("Invalid operation.");
            }

            Console.Write("Do you want to continue? (y/n): ");
            choices = Convert.ToChar(Console.ReadLine());

        } while (choices == 'y' || choices == 'Y');

        Console.WriteLine("Thank You");
        Console.WriteLine("\n");













































    }
}
