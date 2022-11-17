namespace Day9_Practice_AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 9 Practice problem With AddressBook system");
            AddressBook addressBook = new AddressBook();

            Console.WriteLine("--Add Contact Details--");
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Address:");
            string address = Console.ReadLine();
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine("State:");
            string state = Console.ReadLine();
            Console.WriteLine("Zip Code:");
            string zip = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Email Address:");
            string email = Console.ReadLine();
            addressBook.addContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
        }
    }
}

