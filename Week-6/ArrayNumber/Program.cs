

int[] numbers = new int[10];
Random rnd = new Random();

int sum = 0;

//populating the array
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum += numbers[i];
}

foreach (int ele in numbers)
{
    Console.WriteLine(ele);
}

Console.WriteLine($"Kogusumma on {sum}");