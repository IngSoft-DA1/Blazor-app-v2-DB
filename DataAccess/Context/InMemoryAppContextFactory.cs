using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public interface IAppContextFactory
{
    AppContext CreateDbContext();
}

public class InMemoryAppContextFactory : IAppContextFactory
{
    public AppContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
        optionsBuilder.UseInMemoryDatabase("TestDB");

        return new AppContext(optionsBuilder.Options);
    }
}