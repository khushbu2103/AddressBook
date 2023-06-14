using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookAdd
    {
       // public Contact contact;

        public List<Contact> contacts;

        public AddressBookAdd()
        {
            contacts = new List<Contact>();
        }
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

            //this.contact = new Contact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        }

        public void DisplayAdd()
        {
            if (contacts.Count > 0)
            {
                foreach (Contact person in contacts)
                {
                    Console.WriteLine($"first Name: {person.firstName}");
                    Console.WriteLine($"last Name: {person.lastName}");
                    Console.WriteLine($"Address: {person.address}");
                    Console.WriteLine($"City: {person.city}");
                    Console.WriteLine($"State: {person.state}");
                    Console.WriteLine($"Zip Code: {person.zipCode}");
                    Console.WriteLine($"Phone Number: {person.phoneNumber}");
                    Console.WriteLine($"Email: {person.email}");
                }
            }
            else
            {
                Console.WriteLine("there are no contact present in this adress book");
            }
        }

        public void EditContact()
        {
            Console.WriteLine("Enter the first name of the contact you want to edit:");
            string firstNameToEdit = Console.ReadLine();
            Console.WriteLine("Enter the last name of the contact you want to edit:");
            string lastNameToEdit = Console.ReadLine();

            Contact contactToEdit = SearchContact(firstNameToEdit, lastNameToEdit);

            if (contacts != null && contactToEdit.firstName == firstNameToEdit && contactToEdit.lastName == lastNameToEdit)
            {
                Console.WriteLine("Enter the contact's new first name:");
                string newFirstName = Console.ReadLine();
                Console.WriteLine("Enter the contact's new last name:");
                string newLastName = Console.ReadLine();
                Console.WriteLine("Enter the contact's new address:");
                string newAddress = Console.ReadLine();
                Console.WriteLine("Enter the contact's new city:");
                string newCity = Console.ReadLine();
                Console.WriteLine("Enter the contact's new state:");
                string newState = Console.ReadLine();
                Console.WriteLine("Enter the contact's new zip code:");
                string newZipCode = Console.ReadLine();
                Console.WriteLine("Enter the contact's new phone number:");
                string newPhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter the contact's new email:");
                string newEmail = Console.ReadLine();

                contactToEdit.firstName = newFirstName;
                contactToEdit.lastName = newLastName;
                contactToEdit.address = newAddress;
                contactToEdit.city = newCity;
                contactToEdit.state = newState;
                contactToEdit.zipCode = newZipCode;
                contactToEdit.phoneNumber = newPhoneNumber;
                contactToEdit.email = newEmail;

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
            
        }

        public void DeleteContact()
        {
            if(contacts != null)
            {
                Console.WriteLine("Enter the first name of the contact you want to delete:");
                string firstNameToDelete = Console.ReadLine();
                Console.WriteLine("Enter the last name of the contact you want to delete:");
                string lastNameToDelete = Console.ReadLine();
                Contact contactToDelete = SearchContact(firstNameToDelete, firstNameToDelete);
                if (contactToDelete != null && contactToDelete.firstName == firstNameToDelete && contactToDelete.lastName == lastNameToDelete)
                {
                    contactToDelete = null;
                    Console.Write("\nDeleted Successfully!\n");
                }
                else
                {
                    Console.Write("\nNo such person found!\n");
                }
            }
            else
            {
                Console.Write("\nNo such person found!\n");
            }

        }

        public Contact SearchContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.firstName == firstName && contact.lastName == lastName)
                {
                    return contact;
                }
            }
            return null;
        }
    }
}
