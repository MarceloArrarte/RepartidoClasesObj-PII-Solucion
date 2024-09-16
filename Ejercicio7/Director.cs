namespace Ejercicio7;

public class Director
{
    public string Name { get; set; }
    private List<Movie> moviesDirected = new List<Movie>();

    public Director(string name)
    {
        Name = name;
    }

    public void Direct(Movie movie)
    {
        moviesDirected.Add(movie);
        movie.AddDirector(this);
    }
}