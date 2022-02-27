using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    public class DictionaryAddBooks
    {
        public static List<Contact> People = new List<Contact>();
        public static Dictionary<string, List<Contact>> PeopleDictionary = new Dictionary<string, List<Contact>>();
        public void AddPerson()
        {
            Contact person = new Contact();
            Console.Write("Enter Address Book name:");
            string? AddressBookName = Console.ReadLine();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Emai:");
            person.Email = Console.ReadLine();

            Console.Write("Enter Address: ");
            string[] addresses = new string[1];
            addresses[0] = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter zip:");
            person.Zip = Convert.ToInt32(Console.ReadLine());

        }

    }
}
