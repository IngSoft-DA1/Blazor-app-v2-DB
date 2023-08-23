using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class SqlContextFactory
{
    public SqlContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
        optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=Blazor2;User Id=sa;Password=Pass.2022;TrustServerCertificate=true");
        return new SqlContext(optionsBuilder.Options);
    }
}