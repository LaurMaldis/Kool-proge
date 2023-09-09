

Random rnd = new Random();

int MyRanNr;
int RanSum = 0;


for (int i = 0; i < 3; i++)
{
    MyRanNr = rnd.Next(0, 11); // 0 - 10 võtab ühe random numbri
    RanSum = RanSum + MyRanNr;
    Console.WriteLine($"Praegune suvaline number on: {MyRanNr}");
    Console.WriteLine($"Summa on {RanSum}");
};