internal class Program
{
    private static void Main(string[] args)
    {


        //single dimensional
        //////////////////////////////////


        //string[] roles = new string[5];
        //roles[0] = "CompanyMember";
        //roles[1] = "jobseeker";
        //roles[2] = "jobprovider";
        //roles[3] = "admin";
        //roles[4] = "jhv";

        //for (int i = 0; i < roles.Length; i++)
        //{
        //    Console.WriteLine(roles[i]);
        //}
        //Console.ReadLine();

        //////////////////////////////////

        //Console.WriteLine("enter size of the array");
        //int size =Convert.ToInt32(Console.ReadLine());

        //string[] roles = new string [size];

        //Console.WriteLine("enter array elements");

        //for (int i = 0; i < roles.Length; i++) 
        //{
        //    roles[i] = Console.ReadLine();
        //}
        //for (int i = 0; i < roles.Length; i++)
        //{
        //    Console.WriteLine ("\n" +roles[i]);
        //}



        //////////////////////////////////


        // two dimensional

        //string[,] roles = new string[2, 2];

        //roles[0, 0] = "jobprovider  ";
        //roles[0, 1] = "admin ";
        //roles[1, 0] = "jobseeker ";
        //roles[1, 1] = "company member ";

        //for (int i=0;i<2;i++)
        //{
        //    for (int j=0;j<2;j++)
        //    {
        //        Console.Write(roles[i,j]+"");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();


        //////////////////////////////////


        Console.WriteLine("enter number of rows");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter number of cols");
        int cols = Convert.ToInt32(Console.ReadLine());

        string[,] roles = new string[row, cols];

        Console.WriteLine("enter array elements");

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"[{i},{j}]: ");
                roles[i, j] = Console.ReadLine();
            }
        }
        Console.WriteLine("\n ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(roles[i, j]);
            }
            Console.WriteLine();





            ////////////////////////////

            ///jagged

            //string[][] roles = new string[2][];

            //roles[0] = new string[] { "job provider" };
            //roles[1] = new string[] { "job seeker", "job provider", "company member" };

            //for (int i=0;i<roles.Length;i++)
            //{
            //    for (int j = 0; j < roles[i].Length;j++)
            //    {
            //        System.Console.Write(roles[i][j] + "");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            ////////////////////////////


            //Console.WriteLine("enter number of arrays");
            //int groups = int.Parse(Console.ReadLine());

            //string[][] roles = new string[groups][];

            //for (int i = 0; i < groups; i++)
            //{
            //    Console.WriteLine("How many elements in array " + (i + 1) );
            //    int count = int.Parse(Console.ReadLine());

            //    roles[i] = new string[count];

            //    for (int j = 0; j < count; j++)
            //    {
            //        Console.WriteLine("element  " + (j + 1) + " for group " + (i + 1) );
            //        roles[i][j] = Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("arrays :");
            //for (int i = 0; i < roles.Length; i++)
            //{
            //    for (int j = 0; j < roles[i].Length; j++)
            //    {
            //        Console.Write(roles[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();













        }
    }
}
