using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    public class CreateContacts
    {
        public void PersonDetails()
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

            

            Console.WriteLine("Please Enter your Email=:\n");
            string Email = Console.ReadLine();

            Console.WriteLine(FIrst_Name + " " + Last_Name + " " + Address + " " + City + " " + State + " " + Zip_Code + " "+ Email);
        }
    }
}
