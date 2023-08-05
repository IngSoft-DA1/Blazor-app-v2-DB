namespace DataAccess;

using Models;

public class CategoriesRepository
{
    private MemoryDatabase _database;

    public CategoriesRepository(MemoryDatabase database)
    {
        _database = database;
    }

    public List<Category> GetAll()
    {
        return _database.Categories;
    }

    public void Create(Category category)
    {
        category.Id = _database.Categories.Count + 1;
        _database.Categories.Add(category);
    }
    public Category Find(int id)
    {
        return _database.Categories.FirstOrDefault(m => m.Id == id);
    }
    public void Update(Category element)
    {
        _database.Categories = _database.Categories.Select(e => e.Id == element.Id ? element : e).ToList();
    }
    public void Delete(int id)
    {
        _database.Categories.RemoveAll(x => x.Id == id);
    }
}