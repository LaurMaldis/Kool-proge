

Random rnd = new Random();
int cpuRan;
bool loopActive = true;

while (loopActive)
{
    cpuRan = rnd.Next(1, 4);
    Console.WriteLine($"Vali mingi number 1-3ni:");
    int userNum = Int32.Parse(Console.ReadLine());

    if (userNum == cpuRan)
    {
        Console.WriteLine("Õige number!");
        loopActive = false; //break; võin ka kasutada(väljub ise jõuga loopist)
    }   else
    {
        Console.WriteLine($"Vale number! Arvuti genereeris number: {cpuRan}. Proovi uuesti!");
    }
}

Console.WriteLine("Head päevajätku!");