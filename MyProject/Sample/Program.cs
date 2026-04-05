internal class Program
{
    private static void Main(string[] args)
    {

        //problem 1

        //Console.WriteLine("Enter a single character");
        //char a = Console.ReadKey().KeyChar;
        //Console.WriteLine("\n");

        //if (char.IsUpper(a))
        //{
        //    Console.WriteLine(a + " is an upper case");
        //}
        //else if (char.IsLower(a)) 
        //{
        //    Console.WriteLine(a+" is lower case "); 
        //}

        //else if (char.IsDigit(a))
        //{
        //    Console.WriteLine(a+" is a digit ");
        //}

        //else
        //{
        //    Console.WriteLine(a + " is a special character");
        //}


        //problem 2


        //Console.WriteLine("enter amount");
        //int amount = Convert.ToInt32(Console.ReadLine());

        //if (amount > 10000)
        //{
        //    Console.WriteLine("you are eligible for 20% discount \n" + "total discount " + (amount * 20) / 100+);
        //}
        //else if (amount > 5001 & amount < 10000)
        //{
        //    Console.WriteLine("you got 10% discount \n" + "total discount " + (amount * 10) / 100);
        //}

        //else
        //{
        //    Console.WriteLine("no discount" + amount);
        //}


        //problem 3

        //Console.WriteLine("enter a color");
        //string a = Console.ReadLine().ToLower();

        //switch (a)
        //{
        //    case  "red":
        //        Console.WriteLine("stop");
        //        break;
        //    case "green":
        //        Console.WriteLine("go");
        //        break;
        //    case "yellow":
        //        Console.WriteLine("get ready");
        //        break;

        //}



        //problem 4

        //Console.WriteLine("enter age");
        //int a = Convert.ToInt32(Console.ReadLine());

        //if (a > 0 && a <= 12)
        //{
        //    Console.WriteLine("child");
        //}
        //else if (a >= 13 && a <= 19)
        //{
        //    Console.WriteLine("teenager");
        //}
        //else if (a >= 20 && a <= 59)
        //{
        //    Console.WriteLine("adult");
        //}
        //else
        //{
        //    Console.WriteLine("senior cirizen");
        //}




        //problem 5

        //Console.WriteLine("enter balance");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine ("enter amount");
        //int b = Convert.ToInt32(Console.ReadLine());

        //if (b>a)
        //{
        //    Console.WriteLine("insufficient fund");
        //}
        //else if (b<=a)
        //{
        //    Console.WriteLine("withdrawal possible");
        //}


        //problem 6

        //Console.WriteLine("Enter a day  :");
        //string a = Console.ReadLine().ToLower();

        //switch (a)
        //{
        //    case "monday":
        //        Console.WriteLine("weekday");
        //        break;
        //    case "tuesday":
        //        Console.WriteLine("weekday");
        //        break;
        //    case "wednesday":
        //        Console.WriteLine("weekday");
        //        break;
        //    case "thursday":
        //        Console.WriteLine("weekday");
        //        break;
        //    case "friday":
        //        Console.WriteLine("weekday");
        //        break;
        //    case "saturday":
        //        Console.WriteLine("weekend");
        //        break;
        //    case "sunday":
        //        Console.WriteLine("weekend");
        //        break;
        //}



        //problem 7

        Console.WriteLine("enter your weight");
        int w = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your height");
        int h = Convert.ToInt32(Console.ReadLine());

        double bmi = w / (h * h);


        if (bmi < 18.5)
        {
            Console.WriteLine("underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("normal");
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            Console.WriteLine("overweight");
        }
        else
        {
            Console.WriteLine("obese");
        }



        //problem 8

        //Console.WriteLine("guess the secrete number (1-10)");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if (num == 3)
        //{
        //    Console.WriteLine("correct");
        //}
        //else
        //{
        //    Console.WriteLine("wrong guess");
        //}











    }
}