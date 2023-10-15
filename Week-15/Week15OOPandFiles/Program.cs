
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();

foreach (string line in data)
{
    string[] temporary = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(temporary[0], temporary[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"Üks mu lemmikutest filmidest {movie.Title} oli väljastatud {movie.Year}.");
}


static string[] GetDataFromMyFile()
{
    string filePath = @"D:\Visual Studio\repos\Kool-proge\Week-15\Week15OOPandFiles\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{ 
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie (string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}