
Console.WriteLine("Anna enda koerale nimi:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog naaberDog = new Dog("Moink");

Console.WriteLine($"Mu koera nimi on {myDog.Name}.");
Console.WriteLine($"Naabri koera nimi on {naaberDog.Name}.");

myDog.Rename("Kardul");

while (myDog.LeveOfHappiness != 5)
{
    myDog.Bark();
}

myDog.SabaLiputus();
class Dog
{
    private string _name;
    private int _leveOfHappiness;

    //classi constructor
    public Dog(string name) //nime valib kasutaja ise
    {
        _name = name;
        _leveOfHappiness = 0;
    }

    //getter
    public string Name
    { 
        get { return _name; } 
    }
    public int LeveOfHappiness
    { 
        get { return _leveOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Teie koer on ümbernimetatud, uus nimi on {newName}");
    }

    public void Bark()
    { 
         Console.WriteLine("Auh-Auh");
        _leveOfHappiness++; 
    }

    public void SabaLiputus()
    {
        Console.WriteLine("Koera saba liputab!");
    }
}