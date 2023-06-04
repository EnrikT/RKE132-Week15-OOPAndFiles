List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2] , tempArray[1]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favourite movies {movie.Title} was released in {movie.Year}. Rating:{movie.Rating}");
}
static string[] GetDataFromMyFile()
{
    string filepath = @"C:\Users\Enrik\Desktop\dataForRKE132\movies.txt";
    return File.ReadAllLines(filepath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.Write(line);
    }
}

class Movie
{
    string title; //fields dont need '_'
    string year;
    string rating;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }
    public string Rating
    { get { return rating; } }

    public Movie(string _title, string _year , string _rating)
    {
       title = _title;
       year = _year;
       rating = _rating;
    }
}