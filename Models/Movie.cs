namespace Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Director { get; set; }
    public int? ReleaseYear { get; set; }
    public Category Category { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Director: {Director}, ReleaseYear: {ReleaseYear}";
    }
}