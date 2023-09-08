// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida tema sugu (n/m)
//rakendus küsib kasutajalt sisestada perekonnanime
// valikute järel teeb vastava väljundi
//"Welcome, Mr. [sisend]

Console.WriteLine("Valige oma sugu (n/m):");

char userGender = Char.Parse(Console.ReadLine()); // see rida võtab sisendi

Console.WriteLine("Palun öelge oma nimi:");
string userLName = Console.ReadLine(); //

if (userGender == 'm')
{
    Console.WriteLine($"Tere tulemast, hr. {userLName}");
} 
else if (userGender == 'n')
{
    Console.WriteLine($"Tere tulemast, pr. {userLName}");
}
else
{
    Console.WriteLine($"Palun sisestage õige sugu, {userLName}!");
};



//Console.WriteLine($"Tere tulemast {userGender} {userLName}!");
