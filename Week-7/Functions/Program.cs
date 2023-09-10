Console.WriteLine("Kas sa jääd siia (Y) või lahkud(N)? (Y/N)");
string userChoice = Console.ReadLine();

if (userChoice == "Y")
{
    PrintHello();
}
else
{ 
    PrintGoodBye();
}


static void PrintHello() //function ehk meetod
{
    Console.WriteLine("Tere maailm!");
}

static void PrintGoodBye()
{
    Console.WriteLine("Head aega kartul!");
}