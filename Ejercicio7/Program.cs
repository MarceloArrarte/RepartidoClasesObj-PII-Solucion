namespace Ejercicio7;

public class Program
{
    public static void Main(string[] args)
    {
        Actor cage = new Actor("Nicolas Cage", "07/01/1964", "Estadounidense");
        Actor byrne = new Actor("Rose Byrne", "24/07/1979", "Australiana");
        Movie presagio = new Movie("Presagio", "Suspenso", 121, 2009);
        Director proyas = new Director("Alex Proyas");

        Actor martell = new Actor("Jaeden Martell", "04/01/2003", "Estadounidense");
        Actor jenkins = new Actor("Maxwell Jenkins", "03/05/2005", "Estadounidense");
        Movie arcadian = new Movie("Arcadiano", "Thriller", 92, 2024);
        Director brewer = new Director("Benjamin Brewer");
        
        Studio saturn = new Studio("Saturn Films", "Los Ángeles, California, EEUU", 102_000_000);
        saturn.Film(presagio, [cage, byrne], proyas);
        saturn.Film(arcadian, [cage, martell, jenkins], brewer);
        
        saturn.ShowAllMovies();
    }
}