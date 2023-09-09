//modulus - % näitab jääki

//int a = 29;
//int b = 7;

//int c = a % b;  //+/-/*/

//Console.WriteLine(c);

Console.WriteLine("Mis hinde te saite:");
char hinne = Char.Parse(Console.ReadLine());

switch (hinne)
{
    case 'A':
        Console.WriteLine("Suurepärane!");
        break;
    case 'B':
        Console.WriteLine("Väga hea!");
        break;
    case 'C':
        Console.WriteLine("Hea!");
        break;
    case 'D':
        Console.WriteLine("Rahuldav!");
        break;
    case 'E':
        Console.WriteLine("Kasin!");
        break;
    case 'F':
        Console.WriteLine("Puudulik!");
        break;
    default:
        Console.WriteLine("Vale väärtus!");
        break;
};
