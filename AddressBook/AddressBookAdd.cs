using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookAdd
    {
        public void AddContact()
        {
            Console.WriteLine("please enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("please enter address");
            string address = Console.ReadLine();
            Console.WriteLine("please enter city name");
            string city = Console.ReadLine();
            Console.WriteLine("please enter state name");
            string state = Console.ReadLine();
            Console.WriteLine("please enter zip code");
            string zipCode = Console.ReadLine();
            Console.WriteLine("please enter phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("please enter email");
            string email = Console.ReadLine();

            Contact contact = new Contact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        }
    }
}
