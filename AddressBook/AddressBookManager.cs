using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookManager
    {
        public Dictionary<string, AddressBookAdd> addressBooks;

        public AddressBookManager()
        {
            addressBooks = new Dictionary<string, AddressBookAdd>();
        }

        public void AddAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"An address book with the name '{name}' already exists. Please try again with a different name.");
                return;
            }

            AddressBookAdd newAddressBook = new AddressBookAdd();
            addressBooks.Add(name, newAddressBook);
            Console.WriteLine($"Address book '{name}' added successfully.");
        }

        public void DisplayAllAddressBooks()
        {
            if (addressBooks.Count > 0)
            {
                Console.WriteLine("Address books:");
                foreach (string name in addressBooks.Keys)
                {
                    Console.WriteLine($"- {name}");
                }
            }
            else
            {
                Console.WriteLine("No address books found.");
            }
        }

        static void ManageAddressBook(AddressBookAdd addressBook)
        {
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
        public AddressBookAdd GetAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                return addressBooks[name];
            }
            else
            {
                Console.WriteLine($"No address book found with the name '{name}'.");
                return null;
            }
        }
    }
}
