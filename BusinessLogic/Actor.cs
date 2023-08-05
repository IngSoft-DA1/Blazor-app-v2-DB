namespace BusinessLogic;

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

}