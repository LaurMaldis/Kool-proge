

//mata >= 90; bio >= 90; keemia >= 90;

int mata, bio, keemia;

Console.WriteLine("Sisesta oma mata tulemused:");
mata = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma bio tulemused:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta oma keemia tulemused:");
keemia = Int32.Parse(Console.ReadLine());  

if (mata >= 90 && bio >= 90 && keemia >= 90)
{
    Console.WriteLine("Suurepärane, oled nõuetekohane!");
}
 else
{
    Console.WriteLine("Vabandust, aga te pole nõuetekohane!");
}