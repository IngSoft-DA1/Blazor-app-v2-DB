namespace DataAccess.SQL;
using Models;

public class ActorRepositorySql
{
    private SqlContext _database;
    public ActorRepositorySql(SqlContext database)
    {
        _database = database;
    }

    public List<Actor> GetAll()
    {
        return _database.Actors.ToList();
    }

    public void Create(Actor actor)
    {
        _database.Actors.Add(actor);
        _database.SaveChanges();
    }
    public Actor Find(int id)
    {
        return _database.Actors.FirstOrDefault(m => m.Id == id);
    }
    public void Update(Actor element)
    {
        var existingActor = _database.Actors.Find(element.Id);
        
        _database.Entry(existingActor).CurrentValues.SetValues(element);
        _database.SaveChanges();
    }
    public void Delete(int id)
    {
        Actor entry = this.Find(id);
        _database.Actors.Remove(entry);
        _database.SaveChanges();
    }
}