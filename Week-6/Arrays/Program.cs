

string[] fruit = new string[3];
fruit[0] = "ounad";
fruit[1] = "banaanid";
fruit[2] = "apelsinid";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"Su massiivis on {fruitArrayLength} elementi");


for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}


foreach (string element in fruit)
{
    Console.WriteLine(element);
}