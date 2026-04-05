using question_3.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Clothing cloth = new Clothing(1, "shirt", 500);
        Clothing cloth1 = new Clothing(2, "pants", 800);

        Electronics elec = new Electronics(5, "mobile", 25000);
        Electronics elec1 = new Electronics(10, "computer", 87000);


        cloth.CalculateDiscount(500);
        cloth1.CalculateDiscount(800);

        elec.CalculateDiscount(25000);
        elec.CalculateDiscount(87000);



    }

     

    }
