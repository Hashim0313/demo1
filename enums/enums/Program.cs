using petsapp.enums;
using System;
using System.Threading.Channels;


namespace PetsApp_ArraySecondProgram
{
    class Program
    {

        public struct Pet
        {
            public int Id;
            public string petName;
            public petcategory Category;

        }
            
        static void Main(string[] args)
        {
            Pet[] pets = new Pet[10];
            Console.WriteLine("how many pet do you want to add?");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Pet pet = new Pet();
                pet.Id = i + 1;
                Console.WriteLine("Enter pet name:",i+1);
                pet.petName = Console.ReadLine();
                Console.WriteLine("Enter the name of {0} th pet:",i+1);
                int choice;
                bool chance = true;
                do
                {
                    Console.WriteLine("Choose a number Corresponding to Category from this  \n1.Dog\n2.Cat\n3.Bird\n4.Fish\n5.Reptile\n6.Other");
                    choice = Convert.ToInt32(Console.ReadLine());
                    chance = true;
                    switch (choice)
                    {
                        case 1:
                            pet.Category = petcategory.dog;
                            break;
                        case 2:
                            pet.Category = petcategory.cat;
                            break;
                        case 3:
                            pet.Category = petcategory.bird;
                            break;
                        case 4:
                            pet.Category = petcategory.fish;
                            break;
                        case 5:
                            pet.Category = petcategory.reptile;
                            break;
                        case 6:
                            pet.Category = petcategory.other;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            chance = false;
                            break;
                    }
                    } while (chance == false );
                pets[i] = pet;
                {
                    Console.WriteLine("Pet dtails are ");
                    foreach (var p in pets)
                    {
                        if (pet.petName!=null) 
                        {
                            Console.WriteLine("--------------{0}-----------------", pet.petName);

                            Console.WriteLine("Pet Id:{0}", pet.Id);
                            Console.WriteLine("Pet Name:{0}", pet.petName);
                            Console.WriteLine("Pet Category:{0}", pet.Category);
                        }
                    }
                    Console.ReadLine();
                }

            }
            }
        }
    }
