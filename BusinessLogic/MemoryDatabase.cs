namespace BusinessLogic;
using System;

public class MemoryDatabase{
    public List<Movie> Movies { get; set; }

    public MemoryDatabase(){
        Movies = new List<Movie>();
        DefaultMovies();
    }
    public void AddMovie(Movie movie){
        Movies.Add(movie);
    }
    
    public Movie FindMovie(int id){
        return Movies.FirstOrDefault(m => m.Id == id);
    }
    public void UpdateMovie(Movie element){
        Movies = Movies.Select(e => e.Id == element.Id ? element : e).ToList();
    }
    public void DeleteMovie(int id){
        Movies.RemoveAll(x => x.Id == id);
    }


    private void DefaultMovies(){
        Movies.Add(new Movie { Id = 1, Title = "The Shawshank", Director = "Frank Darabont", ReleaseYear = 1994});
        Movies.Add(new Movie { Id = 2, Title = "The Godfather", Director = "Francis Coppola", ReleaseYear = 1972});
        Movies.Add(new Movie { Id = 3, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseYear = 1974});
        Movies.Add(new Movie { Id = 4, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008});
        Movies.Add(new Movie { Id = 5, Title = "The Lord of the Rings", Director = "Peter Jackson" });
        Movies.Add(new Movie { Id = 6, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994});
        Movies.Add(new Movie { Id = 7, Title = "Schindler's List", Director = "Steven Spielberg", ReleaseYear = 1993});
    }

}