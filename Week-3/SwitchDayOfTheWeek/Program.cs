
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0 pühap - 6 laup

switch(weekDay) //väärtus mida kontrollitakse
{
    case 0: //case 0: == if(weekDay == 0)
        Console.WriteLine("It's Sunday.");
        break;
    case 1:
        Console.WriteLine("Esmap");
        break;
    case 2:
        Console.WriteLine("T");
        break; 
    case 3:
        Console.WriteLine("K");
        break;
    case 4:
        Console.WriteLine("N");
        break;
    case 5:
        Console.WriteLine("R");
        break; 
    case 6:
        Console.WriteLine("L");
        break;
};

Console.WriteLine("Naudi oma ilusat päeva!");