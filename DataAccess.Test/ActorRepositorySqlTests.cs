using DataAccess.SQL;
using Models;

namespace DataAccess.Tests;

[TestClass]
public class ActorRepositorySqlTests
{
    private ActorRepositorySql _repository;
    private AppContext _context;
    private readonly IAppContextFactory _contextFactory = new InMemoryAppContextFactory();
    
    [TestInitialize]
    public void SetUp()
    {
        _context = _contextFactory.CreateDbContext();
        _repository = new ActorRepositorySql(_context);
    }
    
    [TestCleanup]
    public void CleanUp()
    {
        _context.Database.EnsureDeleted();
    }

    [TestMethod]
    public void GetAll_ShouldReturnAllActors()
    {
        //Arrange
        var actor = new Actor
        {
            Id = 1, 
            Name = "Tom Hanks", 
            Bio = "Thomas Jeffrey Hanks is an American actor",
            BirthDate = new DateTime(1956, 7, 9) 
        };
        
        _context.Actors.Add(actor);
        _context.SaveChanges();
        
        //Act
        var actorsInDb = _repository.GetAll();
        
        //Assert
        Assert.IsTrue(actorsInDb.Contains(actor));
        Assert.AreEqual(1, actorsInDb.Count);
    }
    
    [TestMethod]
    public void Create_ShouldSaveNewActor()
    {
        //Arrange
        var actor = new Actor
        {
            Id = 1, 
            Name = "Tom Hanks", 
            Bio = "Thomas Jeffrey Hanks is an American actor",
            BirthDate = new DateTime(1956, 7, 9) 
        };
        
        //Act
        _repository.Create(actor);
        
        //Assert
        var actorInDb = _context.Actors.First();
        Assert.AreEqual(actor, actorInDb);
    }
    
}