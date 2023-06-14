using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program!");
            AddressBookAdd addressBook = new AddressBookAdd();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a contact");
                Console.WriteLine("2. Display all contacts");
                Console.WriteLine("3. Edit a contact");
                Console.WriteLine("4. Delete a contact");
                Console.WriteLine("5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.DisplayAdd();
                        break;
                    case 3:
                        addressBook.EditContact();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

   
}
