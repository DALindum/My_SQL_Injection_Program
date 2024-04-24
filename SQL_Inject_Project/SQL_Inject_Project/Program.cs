using SQL_Inject_Project;

Person person = new Person();

string userInput;

Console.WriteLine(" ");
Console.WriteLine("Hello, what would you like to know?");
Console.WriteLine("1: Get All Information of People");
Console.WriteLine("2: Search first name");
Console.WriteLine("q: To quit");
userInput = Console.ReadLine().ToString();

if (userInput == "1")
{
    person.getAllPersons();
}
if (userInput == "2")
{
    Console.WriteLine("What name would you want to search for?");
    string firstName = Console.ReadLine();
    person.searchFirstName(firstName);
}
if (userInput == "q")
{
    return;
}
