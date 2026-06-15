// See https://aka.ms/new-console-template for more information

var movie = new Movie("Inception", "Science Fiction", 148, 13);
movie.ShowInfo();

public class Movie
{
    public string Title { get; }
    public string Genre { get; }
    public int DurationInMinutes { get; }
    public int AgeLimit { get; }

    public Movie(string title, string genre, int durationInMinutes, int ageLimit)
    {
        Title = title;
        Genre = genre;
        DurationInMinutes = durationInMinutes;
        AgeLimit = ageLimit;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"This movie is called {Title}.");
        Console.WriteLine($"It belongs to the {Genre} genre.");
        Console.WriteLine($"The movie lasts {DurationInMinutes} minutes.");
        Console.WriteLine($"The minimum age limit for this movie is {AgeLimit} years.");
    }
}
