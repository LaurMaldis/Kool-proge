string folderPath = @"D:\repos\Kool-proge\Week-9\Lists\";
string fileName = "poeList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> ShoppingList = new List<string>();

if (File.Exists(filePath))
{
    ShoppingList = userTooted();
    File.WriteAllLines(filePath, ShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"{fileName} faili pole olemas.");
    ShoppingList = userTooted();
    File.WriteAllLines(filePath, ShoppingList);
}




static List<string> userTooted()
{
    List<string> kasutajaList = new List<string>();

    while (true)
    {
        Console.WriteLine("Kas soovid toodet lisada (add) või lahkuda (exit)?");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Sisesta toote nimi:");
            string userItem = Console.ReadLine();
            kasutajaList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Järgmise korrani!");
            break;
        }
    }
    return kasutajaList;
}


static void naitaListi(List<string> mingiList)
{
    Console.Clear(); //kustutab eelnevalt konsoolis oleva jutu

    int listiPikkus = mingiList.Count;
    Console.WriteLine($"Teie listis on {listiPikkus} toodet.");

    int i = 1;
    foreach (string item in mingiList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}





