using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    public class AddressBookManager
    {
        public static List<Contact> People = new List<Contact>();
        public static void AddPerson()
        {
            Contact person = new Contact();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Addresses = addresses;

            Console.Write("Enter your City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter your State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Zip number: ");
            person.Zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Email :- ");
            person.Email = Console.ReadLine();

            People.Add(person);
        }
        public static void PrintPerson(Contact person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address 1: " + person.Addresses[0]);
            Console.WriteLine("Address 2: " + person.Addresses[1]);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("Zip : " + person.Zip);
            Console.WriteLine("Email : " + person.Email);
            Console.WriteLine("-------------------------------------------");
        }
        public static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.WriteLine("\nPress exist to Exist address book :) ");
            Console.ReadKey();
        }
    }
}
