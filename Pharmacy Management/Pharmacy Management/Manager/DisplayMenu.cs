using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pharmacy_Management.Manager
{
    public class DisplayMenu
    {
        Pharmacy pharm = new Pharmacy();

        public void Display()
        {
            Console.WriteLine("Choose an option \n 1 : Add medicine \n 2 : List medicine \n 3 : Remove medicine \n 4 : Place order \n 5 : Cancel order");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    pharm.AddMedicine();
                    Display();
                    break;

                case "2":
                    pharm.DisplayAllMedicine();
                    Display();
                    break;

                case "3":
                    pharm.RemoveMedicine();
                    Display();
                    break;

                case "4":
                    pharm.PlaceOrder();
                    Display();
                    break;

                case "5":
                    pharm.CancelOrder();
                    Display();
                    break;




            }
        }



    }
}
