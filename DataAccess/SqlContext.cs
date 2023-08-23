using Microsoft.EntityFrameworkCore;

namespace DataAccess.SQL;
using Models;

public class SqlContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public SqlContext(DbContextOptions<SqlContext> options) : base(options)
    {
        this.Database.Migrate();
        Console.WriteLine("Corriendo migraciones...");
    }
    
    
}
