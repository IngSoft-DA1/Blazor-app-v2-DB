namespace DataAccess;

using Models;

public class MoviesRepository
{

    private MemoryDatabase _database;

    public MoviesRepository(MemoryDatabase database)
    {
        _database = database;
    }

    public List<Movie> GetAll()
    {
        return _database.Movies;
    }

    public void Create(Movie movie)
    {
        movie.Id = _database.Movies.Count + 1;
        _database.Movies.Add(movie);
    }
    public Movie Find(int id)
    {
        return _database.Movies.FirstOrDefault(m => m.Id == id);
    }
    public void Update(Movie element)
    {
        _database.Movies = _database.Movies.Select(e => e.Id == element.Id ? element : e).ToList();
    }
    public void Delete(int id)
    {
        _database.Movies.RemoveAll(x => x.Id == id);
    }
}