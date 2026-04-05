internal class Program
{
    private static void Main(string[] args)
    {
        //int[] marks = new int[4];


        //for (int i = 0; i < marks.Length; i++)
        //{
        //    Console.WriteLine("Enter mark for student " + (i + 1) + ":");
        //    marks[i] = int.Parse(Console.ReadLine());
        //}


        //Console.WriteLine("Marks of all students:");
        //for (int i = 0; i < marks.Length; i++)
        //{
        //    Console.WriteLine("Student " + (i + 1) + ": " + marks[i]);
        //}

        //Console.ReadLine();



        //////////////////////



        //double[] prices = new double[10];


        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write("Enter price of item " + (i + 1) + ": ");
        //    prices[i] = Convert.ToDouble(Console.ReadLine());
        //}


        //double total = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    total = total + prices[i];
        //}


        //double max = prices[0];
        //double min = prices[0];

        //for (int i = 1; i < 10; i++)
        //{
        //    if (prices[i] > max)
        //    {
        //        max = prices[i];
        //    }
        //    if (prices[i] < min)
        //    {
        //        min = prices[i];
        //    }
        //}


        //Console.WriteLine("Total bill: " + total);
        //Console.WriteLine("Costliest item: " + max);
        //Console.WriteLine("Cheapest item: " + min);


        ///////////////////////////

        //string[,] school= new string[3, 5];
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(" enter name and marks ");

        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.WriteLine("enter the marks : ");
        //        school[i, j] = Console.ReadLine();
        //    }
        //}
        //Console.WriteLine(" details of student");
        //for (int i = 0; i < 3; i++)
        //{
        //    int total = 0;
        //    Console.WriteLine(school[i,0] + "");

        //    for (int j=1; j<5; j++)
        //    {
        //        Console.WriteLine(school[i, j] + "");
        //        total +=  Convert.ToInt32(school[i, j]);
        //    }
        //    double average = total / 4.0;
        //    Console.WriteLine("Total marks: " + total+"average : "+average);
        //}
        //    Console.ReadLine();
        //Console.WriteLine("\n");





        /////////////////////////




        //int[,] mat1 = new int[2, 2];
        //int[,] mat2 = new int[2, 2];
        //int[,] result = new int[2, 2];

        //Console.WriteLine("Enter values for first matrix : ");
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    { 
        //     Console.WriteLine("Enter value for mat1[" + i + "," + j + "]: ");
        //        mat1[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //Console.WriteLine("Enter values for second matrix : ");
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.WriteLine("Enter value for mat2[" + i + "," + j + "]: ");
        //        mat2[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        result[i,j] = 0;

        //    }
        //    {
        //        result[i, j] = mat1[i, j] + mat2[i, j];
        //    }
        //}





        /////////////////////////





        bool[][] bus = new bool[3][];

        for (int i = 0; i < 3; i++)
        {

            Console.WriteLine($"Enter the number of seats for row{i + 1}: ");
            int seat = Convert.ToInt32(Console.ReadLine());
            bus[i] = new bool[seat];

            for (int j = 0; j < bus[i].Length; j++)
            {
                bus[i][j] = Convert.ToBoolean(Console.ReadLine());

            }
        }

        Console.WriteLine("\nEntered details: ");
        for (int i = 0; i < 3; i++)
        {

            for (int j = 0; j < bus[i].Length; j++)
            {
               // Console.Write(bus[i][j] + "  ");

                if (bus[i][j] == true)
                {
                    Console.Write(" No seat Available ");
                }
                else
                {
                    Console.Write("seat avaialbe");
                }

            }
            Console.WriteLine();
        }

        //////////////////
        ///





        Console.WriteLine("Monthy Sales report");

        Console.WriteLine("Enter the sales: ");
        int[][] sales = new int[4][];


        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Enter the transactions of Employee{i + 1} : ");
            int transactions = Convert.ToInt32(Console.ReadLine());
            sales[i] = new int[transactions];

            for (int j = 0; j < sales[i].Length; j++)
            {
                sales[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEntered details: ");
        for (int i = 0; i < 4; i++)
        {

            for (int j = 0; j < sales[i].Length; j++)
            {
                Console.Write(sales[i][j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"transactions of Employee{i + 1}:");
            int total = 0;
            for (int j = 0; j < sales[i].Length; j++)
            {

                total += sales[i][j];

            }

            Console.WriteLine(total);
        }
        Console.ReadLine();






    }
}
