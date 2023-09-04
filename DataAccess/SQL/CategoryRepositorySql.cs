namespace DataAccess.SQL;
using Models;

public class CategoryRepositorySql
{
    private SqlContext _database;

    public CategoryRepositorySql(SqlContext database)
    {
        _database = database;
    }

    public List<Category> GetAll()
    {
        return _database.Categories.ToList();
    }

    public void Create(Category category)
    {
        _database.Categories.Add(category);
        _database.SaveChanges();
    }
    public Category Find(int id)
    {
        return _database.Categories.FirstOrDefault(m => m.Id == id);
    }
    public void Update(Category element)
    {
        var existingCategory = _database.Categories.Find(element.Id);
        
        _database.Entry(existingCategory).CurrentValues.SetValues(element);
        _database.SaveChanges();
    }
    public void Delete(int id)
    {
        Category entry = Find(id);
        _database.Categories.Remove(entry);
        _database.SaveChanges();
    }
}