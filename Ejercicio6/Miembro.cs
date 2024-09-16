using System.Collections;

namespace RepartidoClasesObj_PII.Ejercicio6;

public class Miembro
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
    }

    private int id;

    public int Id
    {
        get { return id; }
    }

    private ArrayList librosPrestados;

    public Miembro(string nombre, int id)
    {
        this.nombre = nombre;
        this.id = id;
        librosPrestados = new ArrayList();
    }

    public void PrestarLibro(Libro libro)
    {
        libro.Prestar();
        librosPrestados.Add(libro);
    }

    public void DevolverLibro(Libro libro)
    {
        bool tieneElLibro = false;
        foreach (Libro l in librosPrestados)
        {
            if (l.Titulo == libro.Titulo)
            {
                tieneElLibro = true;
            }
        }

        if (!tieneElLibro)
        {
            Console.WriteLine($"{nombre} no ha pedido prestado el libro {libro.Titulo}, así que no lo puede devolver.");
            return;
        }
        
        libro.Devolver();
        librosPrestados.Remove(libro);
    }
}