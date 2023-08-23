using Microsoft.EntityFrameworkCore;

namespace DataAccess;
using Models;

public class SqlContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Actor> Actors { get; set; }

    public SqlContext(DbContextOptions<SqlContext> options) : base(options)
    {
        this.Database.Migrate(); //Ejecutara las migracione al crear la BD
    }
    
    
}
