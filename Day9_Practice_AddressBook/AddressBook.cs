using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Practice_AddressBook
{
    public class AddressBook
    {
        private List<Contact> ContactList;
        public AddressBook()
        {
            this.ContactList = new List<Contact>();
        }

        public void addContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            this.ContactList.Add(newContact);

        }
    }
}
