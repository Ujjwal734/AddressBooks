using AddressBooks;
Console.WriteLine("Hello, welcome to Address Book...!");
/*Contact person = new Contact();

Console.WriteLine("Enter add command to add person ");
Console.WriteLine("Enter remove commad to remove person ");
Console.WriteLine("Enter print to print details");
Console.WriteLine("Enter exist Command to close Address book");
string command = "";
while (command != "exist")
{
    Console.WriteLine("Please Enter a command :- ");
    command = Console.ReadLine().ToLower();
    switch (command)
    {
        case "add":
            AddressBookManager.AddPerson();
            break;
        case "remove":
            AddressBookManager.Removeperson();
            break;
        case "print":
            AddressBookManager.ListPeople();
            break;
    }
}*/
Console.WriteLine("Using Dictionary and Lambda Function :-");
DictionaryAddBooks dictionaryAdd = new DictionaryAddBooks();
Console.WriteLine("1. Add Person \n2. List Person \n3. Search By First Name \n4. Search By City or State \n5. Edit Contact \n6. Find Person In City Or State \n7. Reading in CSV File \n8. Press 8 to Exist Programe");
int option = 0;
while (option != 8)
{
    Console.WriteLine("Choose Option");
    option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        
        case 1:
            dictionaryAdd.AddPerson();
            break;
        case 2:
            dictionaryAdd.ListPeople();
            break;
        case 3:
            dictionaryAdd.SortByFirstName();
            break;
        case 4:
            dictionaryAdd.sortByCityStateOrZip();
            break;
        case 5:
            dictionaryAdd.Edit();
            break;
        case 6:
            dictionaryAdd.FindPersonInCityOrState();
            break;
        case 7:
            dictionaryAdd.CSVAddresFile();
            break;

        default:
            Console.WriteLine("Choose From The Given Option :) ");
            break;
    }
}