// See https://aka.ms/new-console-template for more information

var movie = new Movie("Inception", "Science Fiction", 148);
movie.ShowInfo();

public class Movie
{
    public string Title { get; }
    public string Genre { get; }
    public int DurationInMinutes { get; }

    public Movie(string title, string genre, int durationInMinutes)
    {
        Title = title;
        Genre = genre;
        DurationInMinutes = durationInMinutes;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Duration: {DurationInMinutes} minutes");
    }
}
