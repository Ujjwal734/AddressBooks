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

            //use LINQ to query the list for the first person with the same first name as the first name the user entered.
            //used lambda operator

            Contact person1 = People.FirstOrDefault(x => x.FirstName == person.FirstName);
            Contact person2 = People.FirstOrDefault(x => x.LastName == person.LastName);
            //Duplicate Check is done on Person Name while adding person to Address Book
            if (person1 != null && person2 != null)
            {
                Console.WriteLine("Sorry this contact exist");
            }
            else
            {
                People.Add(person);
                PeopleDictionary[AddressBookName] = People;
            }
        }
        public void SortByFirstName()
        {
            foreach (var addressBook in PeopleDictionary)
            {
                Console.WriteLine("Address book name:" + addressBook.Key);

                foreach (var person in
                    addressBook.Value.OrderBy(x => x.FirstName))
                {
                    Console.WriteLine("First Name: " + person.FirstName);
                    Console.WriteLine("Last Name: " + person.LastName);
                    Console.WriteLine("Phone Number: " + person.PhoneNumber);
                    Console.WriteLine("Address: " + person.Addresses);
                    Console.WriteLine("city: " + person.City);
                    Console.WriteLine("State : " + person.State);
                    Console.WriteLine("Zip:" + person.Zip);
                    Console.WriteLine("-------------------------------------------");
                }
            }
        }
        public void sortByCityStateOrZip()
        {
            Console.WriteLine("Enter 1 for city 2 for state and 3 for zip to sort the details");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    foreach (var addressBook in PeopleDictionary)
                    {
                        Console.WriteLine("Address book name:" + addressBook.Key);

                        foreach (var person in
                            addressBook.Value.OrderBy(x => x.City))
                        {
                            Console.WriteLine("First Name: " + person.FirstName);
                            Console.WriteLine("Last Name: " + person.LastName);
                            Console.WriteLine("Phone Number: " + person.PhoneNumber);
                            Console.WriteLine("Address: " + person.Addresses);
                            Console.WriteLine("city: " + person.City);
                            Console.WriteLine("State : " + person.State);
                            Console.WriteLine("Zip:" + person.Zip);
                            Console.WriteLine("-------------------------------------------");
                        }
                    }
                    break;
                case 2:
                    foreach (var addressBook in PeopleDictionary)
                    {
                        Console.WriteLine("Address book name:" + addressBook.Key);

                        foreach (var person in
                            addressBook.Value.OrderBy(x => x.State))
                        {
                            Console.WriteLine("First Name: " + person.FirstName);
                            Console.WriteLine("Last Name: " + person.LastName);
                            Console.WriteLine("Phone Number: " + person.PhoneNumber);
                            Console.WriteLine("Address: " + person.Addresses);
                            Console.WriteLine("city: " + person.City);
                            Console.WriteLine("State : " + person.State);
                            Console.WriteLine("Zip:" + person.Zip);
                            Console.WriteLine("-------------------------------------------");
                        }
                    }
                    break;
                case 3:
                    foreach (var addressBook in PeopleDictionary)
                    {
                        Console.WriteLine("Address book name:" + addressBook.Key);

                        foreach (var person in
                            addressBook.Value.OrderBy(x => x.Zip))
                        {
                            Console.WriteLine("First Name: " + person.FirstName);
                            Console.WriteLine("Last Name: " + person.LastName);
                            Console.WriteLine("Phone Number: " + person.PhoneNumber);
                            Console.WriteLine("Address: " + person.Addresses);
                            Console.WriteLine("city: " + person.City);
                            Console.WriteLine("State : " + person.State);
                            Console.WriteLine("Zip:" + person.Zip);
                            Console.WriteLine("-------------------------------------------");
                        }
                    }
                    break;
            }
        }
        public void ListPeople()
        {
            if (PeopleDictionary.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (KeyValuePair<string, List<Contact>> valuePair in PeopleDictionary)
            {
                Console.WriteLine("Address book name:" + valuePair.Key);
                foreach (Contact person in valuePair.Value)
                {

                    Console.WriteLine("First Name: " + person.FirstName);
                    Console.WriteLine("Last Name: " + person.LastName);
                    Console.WriteLine("Phone Number: " + person.PhoneNumber);
                    Console.WriteLine("Address: " + person.Addresses);
                    Console.WriteLine("city: " + person.City);
                    Console.WriteLine("State : " + person.State);
                    Console.WriteLine("Zip:" + person.Zip);
                    Console.WriteLine("-------------------------------------------");
                }
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public void Edit()
        {
            Console.WriteLine("Enter the first name of the person you would like to edit.");
            string firstName = Console.ReadLine();
            Contact person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person != null)
            {
                People.Remove(person);
                Console.WriteLine("Please detail again As you want changes!!!");
                Contact person1 = new Contact();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("Enter Email:");
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

                People.Add(person);
                Console.ReadKey();

                return;
            }
            else
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
            }
        }

    }
}
