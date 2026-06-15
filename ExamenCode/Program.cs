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
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Duration: {DurationInMinutes} minutes");
        Console.WriteLine($"Age Limit: {AgeLimit}+");
    }
}
