//temp <= 0 jääkulm
//temp > 0 && temp < 10 külm
//temp >= 10 && temp < 15 norm
//temp >= 15 && temp < 20 soe
//temp >= 20 && temp < 30 kuum
//temp >= 30 tulikuum

Console.WriteLine("Sisesta veetemperatuur: ");
int temp = Int32.Parse(Console.ReadLine());

if(temp >= 30)
{
    Console.WriteLine("Tulikuum");
}
else if (temp >= 20 &&  temp < 30)
{
    Console.WriteLine("Kuum");
}
else if (temp >= 10 && temp < 20)
{
    Console.WriteLine("Normaalne");
}
else if (temp > 1 && temp < 15)
{
    Console.WriteLine("Külm");
}
else if (temp <= 0 )
{
    Console.WriteLine("Jääkülm");
}
