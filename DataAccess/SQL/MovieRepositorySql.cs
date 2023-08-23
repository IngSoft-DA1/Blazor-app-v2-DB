namespace DataAccess.SQL;
using Models;


public class MoviesRepositorySql
{
    private SqlContext _database;

    public MoviesRepositorySql(SqlContext database)
    {
        _database = database;
    }

    public List<Movie> GetAll()
    {
        return _database.Movies.ToList();
    }

    public void Create(Movie movie)
    {
        movie.Id = _database.Movies.Count() + 1;
        _database.Movies.Add(movie);
    }
    public Movie Find(int id)
    {
        return _database.Movies.FirstOrDefault(m => m.Id == id);
    }
    public void Update(Movie element)
    {
        var existingMovie = _database.Movies.Find(element.Id);
        
        _database.Entry(existingMovie).CurrentValues.SetValues(element);
        _database.SaveChanges();
    }
    public void Delete(int id)
    {
        Movie entry = this.Find(id);
        _database.Movies.Remove(entry);
    }
}