
Console.WriteLine("Sisesta sõna:");
string UserInput = Console.ReadLine();




PrintAny(UserInput); //userInput on argument

static void PrintAny(string anyString) //anyString - on lihtsalt parameeter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{anyString}");
    }
}