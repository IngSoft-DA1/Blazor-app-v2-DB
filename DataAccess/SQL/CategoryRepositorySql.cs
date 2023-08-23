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
        category.Id = _database.Categories.Count() + 1;
        _database.Categories.Add(category);
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
        Category entry = this.Find(id);
        _database.Categories.Remove(entry);
    }
}