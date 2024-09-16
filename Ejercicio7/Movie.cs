namespace Ejercicio7;

public class Movie
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public int Year { get; set; }
    private List<Actor> actors = new List<Actor>();
    private Director director;
    public Director Director { get; }

    public Movie(string name, string genre, int duration, int year)
    {
        Name = name;
        Genre = genre;
        Duration = duration;
        Year = year;
    }

    public void AddActor(Actor actor)
    {
        if (!actors.Contains(actor))
        {
            actors.Add(actor);
        }
    }

    public void AddDirector(Director director)
    {
        if (this.director != null)
        {
            Console.WriteLine($"{this.director.Name} ya está dirigiendo {Name}");
            return;
        }

        this.director = director;
    }

    public override string ToString()
    {
        return $"Película: {Name}, con {string.Join(", ", actors.Select(a => a.Name))}, dirigida por {director.Name}";
    }
}