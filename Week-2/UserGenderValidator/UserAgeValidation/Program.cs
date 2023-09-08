// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajalt vanust
// kui kasutaja on noorem kui 13, siis konsool ütleb, et sa oled insta jaoks liiga noor
// muidu et tere tulemast instasse


Console.WriteLine("Tere, palun öelge oma vanus:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum); //bolean on true or false

Console.WriteLine($"Esialgne sisend on {isAgeNumber}. Isik on {userAgeNum} aastat vana.");

if (isAgeNumber)
{
    if (userAgeNum < 13)
    {
        Console.WriteLine($"Te olete {userAgeNum} ning ei tohi instagrammi kasutada!");
    }
    else
    {
        Console.WriteLine("Tere tulemast Instagrammi!");
    }
}
else
{
    Console.WriteLine("Ei suutnud teie vanust lugeda.");
};

//int userAge = Int32.Parse(Console.ReadLine());
//if (userAge < 13)
//{
//    Console.WriteLine($"Te olete {userAge} ning ei tohi instagrammi kasutada!");
//}
//else if (userAge => 13)
//{
//    Console.WriteLine("Tere tulemast Instagrammi!");
//};