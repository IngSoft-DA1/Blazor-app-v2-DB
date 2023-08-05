namespace DataAccess;

using Models;

public class ActorsRepository
{
    private MemoryDatabase _database;
    public ActorsRepository(MemoryDatabase database)
    {
        _database = database;
    }

    public List<Actor> GetAll()
    {
        return _database.Actors;
    }

    public void Create(Actor actor)
    {
        actor.Id = _database.Actors.Count + 1;
        _database.Actors.Add(actor);
    }
    public Actor Find(int id)
    {
        return _database.Actors.FirstOrDefault(m => m.Id == id);
    }
    public void Update(Actor element)
    {
        _database.Actors = _database.Actors.Select(e => e.Id == element.Id ? element : e).ToList();
    }
    public void Delete(int id)
    {
        _database.Actors.RemoveAll(x => x.Id == id);
    }
}