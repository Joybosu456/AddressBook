using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    public class AddressBookInharitance
    {
        public void Display()
        {
            Console.WriteLine("Please Enter your First Name=:");
            string FIrst_Name = Console.ReadLine();

            Console.WriteLine("Please Enter your last Name=:\n");
            string Last_Name = Console.ReadLine();

            Console.WriteLine("Please Enter your Address=:\n");
            string Address = Console.ReadLine();

            Console.WriteLine("Please Enter your city=:\n");
            string City = Console.ReadLine();

            Console.WriteLine("Please Enter your State=:\n");
            string State = Console.ReadLine();

            Console.WriteLine("Please Enter your Zip code=:\n");
            int Zip_Code = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Phone number");
            long phone = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please Enter your Email=:\n");
            string Email = Console.ReadLine();

            Console.WriteLine(FIrst_Name + " " + Last_Name + " " + Address + " " + City + " " + State + " " + Zip_Code + " " + phone + " " + Email);
        }
    }
    public class AddressBook : AddressBookInharitance
    {
        public void DisplayOne()
        {
            Console.WriteLine("Please Enter your First Name=:");
            string FIrst_Name2 = Console.ReadLine();

            Console.WriteLine("Please Enter your last Name=:\n");
            string Last_Name2 = Console.ReadLine();

            Console.WriteLine("Please Enter your Address=:\n");
            string Address2 = Console.ReadLine();

            Console.WriteLine("Please Enter your city=:\n");
            string City2 = Console.ReadLine();

            Console.WriteLine("Please Enter your State=:\n");
            string State2 = Console.ReadLine();

            Console.WriteLine("Please Enter your Zip code=:\n");
            int Zip_Code2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Phone number");
            long Phone2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please Enter your Email=:\n");
            string Email2 = Console.ReadLine();

            Console.WriteLine(FIrst_Name2 + " " + Last_Name2 + " " + Address2 + " " + City2 + " " + State2 + " " + Zip_Code2 + "  " + Phone2 + " " + Email2);
        }

    }
    public class Edit: AddressBookInharitance
    {
        public void DisplayTwo()
        {
            Console.WriteLine("Please Enter your First Name=:");
            string FIrst_Name = Console.ReadLine();

            Console.WriteLine("Please Enter your last Name=:");
            string Last_Name = Console.ReadLine();

            Console.WriteLine("Please Enter your Address=:");
            string Address = Console.ReadLine();

            Console.WriteLine("Please Enter your city=:");
            string City = Console.ReadLine();

            Console.WriteLine("Please Enter your State=:");
            string State = Console.ReadLine();

            Console.WriteLine("Please Enter your Zip code=:");
            int Zip_Code = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Phone number");
            long phone = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please Enter your Email=:");
            string Email = Console.ReadLine();

            Console.WriteLine(FIrst_Name + " " + Last_Name + " " + Address + " " + City + " " + State + " " + Zip_Code + "  " + phone + " " + Email);
        }
    }
}

    
