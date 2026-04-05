using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Exercise.Models;
using Exercise.Interface;
using Exercise.Enums;
using Exercise.Manager;
using Exercise.Exceptions;



namespace Exercise.Repository
{
    public class UserRepository : IUserRepository
    {

        private static List<User> users = new List<User>();


        public User loggeduser;

        int usercount = 0;


        public void Register()
        {
            try
            {

                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("FirstName");
                string firstname = Console.ReadLine();

                Console.WriteLine("LastName");
                string lastname = Console.ReadLine();



                Console.WriteLine("Email");
                string Email = Console.ReadLine();

               string newEmail = ValidateEmail(Email);
                //Console.WriteLine("\n(email is valid)\n");



                Console.WriteLine("Phone");
                string Phone = Console.ReadLine();

                string newPhone = ValidatePhone(Phone);
                //Console.WriteLine("\n(valid phone number)\n");



                Role roles = Role.Admin;
                Console.WriteLine("Choose Role \n 1 : Admin \n: 2 Job Seeker \n 3: Job Provider");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        roles = Role.Admin;
                        break;
                    case 2:
                        roles = Role.JobSeeker;
                        break;

                    case 3:
                        roles = Role.JobProvider;
                        break;

                }
                Console.WriteLine("Password");
                string Password = Console.ReadLine();

                string newPassword=ValidatePassword(Password);
                //Console.WriteLine("\n(Valid password)\n");

                users.Add(new User(id, firstname, lastname, newEmail, newPhone, newPassword, roles));

            }

            catch(InvalidEmailException ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            catch (InvalidPhoneNumberException ex)
            {
                Console.WriteLine(ex.Message);
                

            }

            catch(InvalidPasswordException ex)
            {
                Console.WriteLine(ex.Message);
                
            }

}

        public User Login()
        {
            
                Console.WriteLine("enter Email");
                string Email = Console.ReadLine();

                Console.WriteLine("enter Password");
                string Password = Console.ReadLine();

                foreach (var e in users)
                {
                    if (e.Email == Email && e.Password == Password)
                    {
                        loggeduser = e;


                        Console.WriteLine("login successfull");
                        return e;
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials");
                    }

                }
                return loggeduser;
            }
           
            


        public void NewRegistration()
        {
            foreach (var b in users)
            {
                Console.WriteLine($"\nId : {b.Id}");
                Console.WriteLine($"\nFirstName : {b.FirstName}");
                Console.WriteLine($"\nLastName : {b.LastName}");
                Console.WriteLine($"\nEmail : {b.Email}");
                Console.WriteLine($"\nPhone : {b.Phone}");
                Console.WriteLine($"\nPassword : {b.Password}");
                Console.WriteLine($"\nRole : {b.Roles}");
            }
        }

       


    
          public string ValidateEmail(string Email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(Email, pattern))
            {
                
                Console.WriteLine("Enter new email");
                string newEmail = Console.ReadLine();
                
                return newEmail;
                throw new InvalidEmailException("invalid email");

            }
            return Email;
        }

        public string ValidatePhone(string phone)
        {
            string pattern = @"^\+?[1-9]\d{9,14}$";

            if (!Regex.IsMatch(phone,pattern))
            {
                Console.WriteLine("Enter new phone");
                string newPhone = Console.ReadLine();

                return newPhone;
                throw new InvalidPhoneNumberException("invalid phone number");

                
            }
            return phone;

        }

        public string ValidatePassword(string Password)
        {
            if (Password.Length < 8)
            {
                Console.WriteLine("Enter new password");
                string newPassword = Console.ReadLine();

                return newPassword;
                throw new InvalidPasswordException("password must be atleast 8 digits");
               
            }
            return Password;
        }

    }
}








