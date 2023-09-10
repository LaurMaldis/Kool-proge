
//string[] heroes = { "Kartulmees", "Monke Kukk", "Ants Mets", "Keere Asd" };
//string[] villains = { "Kuri", "Ats", "joodik Pets", "Näts", "Peet" };
string folderPath = @"D:\repos\Kool-proge\Week-8\EpicGame\";
string heroesFile = "heroes.txt";
string villainsFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroesFile)); //variant ka File.ReadAllLines(folderPath + heroesFile)
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainsFile));
string[] weapon = { "kahvel", "lusikas", "kapsas", "labidas", "juhe" };


string hea = GetRndValueFromArray(heroes);
string kuri = GetRndValueFromArray(villains);
string herorelv = GetRndValueFromArray(weapon);
string kurirelv = GetRndValueFromArray(weapon);

int heroHP = GetCharHP(hea);
int villainHP = GetCharHP(kuri);
int heroStrikeStr = heroHP;
int villainStr = villainHP;


Console.WriteLine($"Kuritegija on {kuri} ({villainHP}HP), kes üritab maailma vallutada {kurirelv} käes!");
Console.WriteLine($"Teda peatab kangelane {hea} ({heroHP}HP), käes on tal {herorelv}!");


while(heroHP > 0 && villainHP > 0)
{
    heroHP = heroHP - hitDMG(kuri, villainStr);
    villainHP = villainHP - hitDMG(hea, heroStrikeStr);
}

Console.WriteLine($"{hea} jäi {heroHP}");
Console.WriteLine($"{kuri} jäi {villainHP}");

if (heroHP > 0 )
{
    Console.WriteLine($"Päev on päästetud {hea} poolt!");
}
else if ( villainHP > 0 )
{
    Console.WriteLine($"Kurjuse tõi päeva {kuri}!");
}
else
{
    Console.WriteLine("Jäi tasavägine viik!");
}


static string GetRndValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int rndIndex = rnd.Next( 0, someArray.Length );
    string rndStringFromArray = someArray[rndIndex];
    return rndStringFromArray;
}

static int GetCharHP(string charName)
{
    if(charName.Length < 10)
    {
        return 10;
    }
    else
    {
        return charName.Length;
    }
}

static int hitDMG(string CharName, int charHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, charHP);

    if(strike == 0)
    {
        Console.WriteLine($"{CharName} lõi mööda!");
    }
    else if (strike == charHP - 1)
    {
        Console.WriteLine($"{CharName} lõi väga valusalt!");
    }
    else
    {
        Console.WriteLine($"{CharName} tegi {strike} DMG");
    }

    return strike;
}