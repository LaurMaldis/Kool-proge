
string[] snacks = { "šoko", "diiz nuts", "kartul", "kapsas", "kana", "porgand" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Täna me sööme {snacks[randomIndex]}.");


string[] colors = { "red", "green", "blue", "pink", "yellow" };

for (int i = colors - 1; i > 0; i--)
{
    Console.WriteLine(colors[i]);
}