namespace Ejercicio7;

public class Studio
{
    public string Name { get; set; }
    public string CityOfOrigin { get; set; }
    public double YearlyRevenue { get; set; }
    private List<Movie> moviesProduced = new List<Movie>();

    public Studio(string name, string city, double yearlyRevenue)
    {
        Name = name;
        CityOfOrigin = city;
        YearlyRevenue = yearlyRevenue;
    }

    public void Film(Movie movie, List<Actor> actors, Director director)
    {
        foreach (Actor actor in actors)
        {
            actor.ActIn(movie);
            movie.AddActor(actor);
        }

        director.Direct(movie);
        moviesProduced.Add(movie);
    }

    public void ShowAllMovies()
    {
        foreach (Movie movie in moviesProduced)
        {
            Console.WriteLine(movie);
        }
    }
}