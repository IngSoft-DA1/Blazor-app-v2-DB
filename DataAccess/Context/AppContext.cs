using Microsoft.EntityFrameworkCore;

namespace DataAccess;
using Models;

public class AppContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Actor> Actors { get; set; }

    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
        if (!Database.IsInMemory())
        {
            Database.Migrate(); //Ejecutara las migracione al crear la BD
        }
    }
    
    
}
