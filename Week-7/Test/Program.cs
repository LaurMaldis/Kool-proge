
Console.WriteLine("Kas hetkene sisestus C või F?");
char sisestus = Char.Parse(Console.ReadLine());

Console.WriteLine("Sisesta temperatuur:");
int temp = Int32.Parse(Console.ReadLine());

switch (sisestus)
{
    case 'C':
        ConvertToFahrenheit(temp);
    break;

    case 'F':
        ConvertToCelsius(temp);
     break;

    default:
        Console.WriteLine("Sisestage õiged andmed!");
    break;
}


static void ConvertToCelsius(int temp)
{
    Console.WriteLine($"{(temp - 32) * 5 / 9}");
}

static void ConvertToFahrenheit(int temp)
{
    Console.WriteLine($"{(temp * 9) / 5 + 32}");
}

