using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

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

            Console.Write("Enter First Name :- ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name :- ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number :- ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Email :- ");
            person.Email = Console.ReadLine();

            Console.Write("Enter Address :- ");
            string[] addresses = new string[1];
            addresses[0] = Console.ReadLine();

            Console.Write("Enter City :- ");
            person.City = Console.ReadLine();
            Console.Write("Enter State :- ");
            person.State = Console.ReadLine();

            Console.Write("Enter zip :- ");
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
        public void FindPersonInCityOrState()
        {
            Console.WriteLine("Enter  1. for city 2. state to find for particular person");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Choose Type city else or state to find perticular person");
                    string city1 = Console.ReadLine();

                    //creating list of person according to city
                    List<Contact> cityWisePeople = new List<Contact>();
                    Dictionary<string, List<Contact>> cityWisePeopleDictionary = new Dictionary<string, List<Contact>>();

                    foreach (KeyValuePair<string, List<Contact>> valuePair in PeopleDictionary)
                    { //for state do the same thing for state
                        Contact person1 = valuePair.Value.Find(x => x.City.ToLower() == city1.ToLower());
                        if (person1 != null)
                        {
                            cityWisePeople.Add(person1);
                        }
                    }
                    cityWisePeopleDictionary[city1] = cityWisePeople;
                    Console.WriteLine($"People in {city1}: ");
                    foreach (var city in cityWisePeopleDictionary.Keys)
                    {
                        if (city.ToLower() == city1.ToLower())
                        {
                            foreach (var person in cityWisePeopleDictionary[city])
                            {
                                if (person != null)
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
                    }
                    int countPeople = cityWisePeopleDictionary.Count;
                    Console.WriteLine("Total number of people in perticular city:" + countPeople);
                    break;
                case 2:
                    Console.WriteLine("Enter state to find perticular person");
                    string SearchAccordingstate = Console.ReadLine();

                    //creating list of person according to city
                    List<Contact> stateWisePeople = new List<Contact>();
                    Dictionary<string, List<Contact>> stateWisePeopleDictionary = new Dictionary<string, List<Contact>>();

                    foreach (KeyValuePair<string, List<Contact>> valuePair in PeopleDictionary)
                    { //Using lambda => here
                        Contact person1 = valuePair.Value.Find(x => x.State.ToLower() == SearchAccordingstate.ToLower());
                        if (person1 != null)
                        {
                            stateWisePeople.Add(person1);
                        }
                    }
                    stateWisePeopleDictionary[SearchAccordingstate] = stateWisePeople;
                    Console.WriteLine($"People in {SearchAccordingstate}: ");
                    foreach (var state in stateWisePeopleDictionary.Keys)
                    {
                        if (state.ToLower() == SearchAccordingstate.ToUpper())
                        {
                            foreach (var person in stateWisePeopleDictionary[state])
                            {
                                if (person != null)
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
                    }
                    int countPeople1 = stateWisePeopleDictionary.Count;
                    Console.WriteLine("Total number of people in perticular city:" + countPeople1);
                    break;
                default:
                    Console.WriteLine("Wrong choice!!");
                    break;
            }
        }
        public void CSVAddresFile()
        {
            string importfilePath = @"C:\Users\Ujjwal\source\repos\AddressBooks\AddressBooks\Contactss.csv";
            string exportfilePath = @"C:\Users\Ujjwal\source\repos\AddressBooks\AddressBooks\Contactss1.csv";
            using (var reader = new StreamReader(importfilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read data sucessfully from address Csv.");
                foreach (Contact contactdata in records)
                {
                    Console.WriteLine(contactdata.FirstName);
                    Console.WriteLine(contactdata.LastName);
                    Console.WriteLine(contactdata.PhoneNumber);
                    Console.WriteLine(contactdata.Addresses);
                    Console.WriteLine(contactdata.City);
                    Console.WriteLine(contactdata.State);
                    Console.WriteLine(contactdata.Zip);
                    Console.WriteLine(contactdata.Email);
                }
                Console.WriteLine("Reading From CSV File and Write to CSV File");
                using (var writer = new StreamWriter(exportfilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
