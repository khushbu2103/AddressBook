using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public int phoneNumber;
        public string email;

        public AddressBook(string firstName, string lastName, string address, string city, string state, int zipCode, int phoneNumber, string email )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
            Console.ReadLine();
        }
        

    }
}
