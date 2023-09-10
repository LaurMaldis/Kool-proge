

Console.WriteLine("Sisesta tehtetüüp (+/-):");
char userTehe = Char.Parse(Console.ReadLine());
Console.WriteLine("Sisesta a väärtus:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Sisesta b väärtus:");
int secNum = Int32.Parse(Console.ReadLine());

switch (userTehe)
{
    case '+':
        Liitmine(firstNum, secNum); 
    break;

    case '-':
        Lahutamine(firstNum, secNum);
    break;
    default:
        Console.WriteLine("Error, pane õiged väljundid!");
    break;
}


static void Liitmine(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

static void Lahutamine(int a, int b)
{
        Console.WriteLine($"{a} - {b} = {a - b} ");
}
    
