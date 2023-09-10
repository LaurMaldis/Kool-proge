

//eesmärk allahindluse arvutamine, lõpphinna arvutamine
//total < 10 - 1%
//total >= 10 && total < 20 - 5% ale
//Total >=20 - 10% ale

Console.WriteLine("Palju teie kogusumma on?");
int sisestus = Int32.Parse(Console.ReadLine());

double discount = Allahindlus(sisestus);
Console.WriteLine($"Allahindlus on {discount}%");

double uusKogusumma = KalkKogu(sisestus, discount);
Console.WriteLine($"Teie uus kogusumma on {uusKogusumma}");

static double Allahindlus(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20) 
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double KalkKogu(double sisestus, double discount)
{
    double summa = sisestus- (sisestus * discount) / 100;
    return summa;
}
