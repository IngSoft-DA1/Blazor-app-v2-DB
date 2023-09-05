namespace Models;

public class Actor
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Bio { get; set; }
    public DateTime? BirthDate { get; set; }


    public string getBirthDate()
    {
        return BirthDate?.ToString("dd-MM-yyyy") ?? "";
    }
    
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (GetType() != obj.GetType()) return false;
        var actor = (Actor) obj;
        return Id == actor.Id;
    }
}