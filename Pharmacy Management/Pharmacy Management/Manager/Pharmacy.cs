using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Management.Models;
using Pharmacy_Management.Interface;
using Pharmacy_Management.Exception;

namespace Pharmacy_Management.Manager
{
    public class Pharmacy : IMedicine
    {
        public List<Medicine> med = new List<Medicine>();

        public static int ordermed = 0;

        public void AddMedicine()
        {
            Console.WriteLine("enter medicine id");
            int MedicineId = Convert.ToInt32(Console.ReadLine());

                                                                Console.WriteLine("");

            Console.WriteLine("enter medicine name");
            string Name = Console.ReadLine();

                                                                Console.WriteLine("");

            Console.WriteLine("enter Price");
            string Price = Console.ReadLine();

                                                                 Console.WriteLine("");

            Console.WriteLine("enter stock quantity");
            int QuantityInStock = Convert.ToInt32(Console.ReadLine());

                                                                 Console.WriteLine("");

            med.Add(new Medicine(MedicineId, Name, Price, QuantityInStock));
        }

        public void DisplayAllMedicine()
        {
            foreach(var d in med)
            {
                Console.WriteLine("\n***Available medicines***\n");

                Console.WriteLine($"\nMedicine Id : {d.MedicineId}");
                Console.WriteLine($"\nMedicine Name : {d.Name}");
                Console.WriteLine($"\nMedicine Price : {d.Price}");
                Console.WriteLine($"\nMedicine Quantity : {d.QuantityInStock}\n\n******");
            }
        }

        public void RemoveMedicine()
        {
            try
            {
                Console.WriteLine("Enter medicine id");
                int id = Convert.ToInt32(Console.ReadLine());
                Medicine m = med.Find(x => x.MedicineId == id);
                if (m != null)
                {
                    med.Remove(m);
                }
                else
                {
                    throw new MedicineNotFoundException("*** medicine not found ***");

                }
            }
            catch (MedicineNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("");
        }

        public void PlaceOrder()
        {
            try
            {
                Console.WriteLine("enter id");
                int Id = Convert.ToInt32(Console.ReadLine());

                Medicine m = med.Find(x => x.MedicineId == Id);
                if (m != null)
                {
                    Console.WriteLine("how many medicines ? ");
                    ordermed = Convert.ToInt32(Console.ReadLine());
                    if (m.QuantityInStock >= ordermed)
                    {
                        m.QuantityInStock -= ordermed;
                    }
                    else
                    {
                        throw new OutOfStockException("medicine out of stock");
                    }
                }
                else
                {
                    throw new MedicineNotFoundException("medicine not found");
                }
            }
            catch(OutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(MedicineNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CancelOrder()
        {
            try
            {
                Console.WriteLine("enter id");
                int id = Convert.ToInt32(Console.ReadLine());

                Medicine c = med.Find(x => x.MedicineId == id);
                if (c != null)
                {
                    Console.WriteLine("How many medicine you want to cancel ?");
                    int Corder = Convert.ToInt32(Console.ReadLine());

                    if (Corder <= ordermed)
                    {
                        c.QuantityInStock += Corder;
                    }
                    else
                    {
                        throw new OutOfStockException("not valid ");
                    }
                }
                else
                {
                    throw new MedicineNotFoundException("medicine not found");
                }


            }
            catch (OutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            catch (MedicineNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        }
    }

