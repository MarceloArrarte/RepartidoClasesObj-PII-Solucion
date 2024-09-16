namespace RepartidoClasesObj_PII.Ejercicio6;

public class Libro
{
    private string titulo;
    
    public string Titulo
    {
        get { return titulo; }
    }

    private string autor;

    public string Autor
    {
        get { return autor; }
    }

    private bool disponible;

    public bool Disponible
    {
        get { return disponible; }
    }

    public Libro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.disponible = true;
    }

    public void Prestar()
    {
        if (!disponible)
        {
            Console.WriteLine($"El libro {titulo} no está disponible.");
            return;
        }
        
        disponible = false;
    }

    public void Devolver()
    {
        if (disponible)
        {
            Console.WriteLine($"El libro {titulo} ya fue devuelto.");
            return;
        }
        
        disponible = true;
    }

    public override string ToString()
    {
        return $"Título: {titulo}, Autor: {autor}";
    }
}