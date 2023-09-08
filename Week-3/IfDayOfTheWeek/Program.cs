
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("On pühapäev");
} 
else if (weekDay == 1)
{
    Console.WriteLine("On esmaspäev");
}
else if (weekDay == 2)
{
    Console.WriteLine("On teisipäev");
}
else if (weekDay == 3)
{
    Console.WriteLine("On kolmapäev");
}
else if (weekDay == 4)
{
    Console.WriteLine("On neljapäev");
}
else if (weekDay == 5)
{
    Console.WriteLine("On reede");
}
else if (weekDay == 6)
{
    Console.WriteLine("On laupäev");
};