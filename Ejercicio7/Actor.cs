namespace Ejercicio7;

public class Actor
{
    public string Name { get; set; }
    public string DateOfBirth { get; set; }
    public string Nationality { get; set; }
    private List<Movie> movies = new List<Movie>();

    public Actor(string name, string dateOfBirth, string nationality)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Nationality = nationality;
    }

    public void ActIn(Movie movie)
    {
        if (!movies.Contains(movie))
        {
            movies.Add(movie);
        }
    }
}