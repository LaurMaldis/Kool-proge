
int sum = 0;

for (int i = 1; i <= 10; i++)  //i-- == i - 1
{
    Console.WriteLine($"i on {i}");
    Console.WriteLine($"Praegune summa on: {sum}");
    sum = sum + i;
}

Console.WriteLine($"Final total on {sum}");