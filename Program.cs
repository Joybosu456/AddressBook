using System;

namespace NoteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            CreateContacts name=new CreateContacts();
            name.PersonDetails();
        }
    }
}

