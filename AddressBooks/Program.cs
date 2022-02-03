using AddressBooks;
Console.WriteLine("Hello, welcome to Address Book...!");
Contact person = new Contact();

Console.WriteLine("Enter add command to add add person ");
Console.WriteLine("Enter remove commad to remove person ");
Console.WriteLine("Enter print to print details");
Console.WriteLine("Enter Exist Command to close Address book");
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
 
         
        case "print":
            AddressBookManager.ListPeople();
            break;
    }
}
