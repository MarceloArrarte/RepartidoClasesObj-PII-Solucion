using System.Collections;

namespace RepartidoClasesObj_PII.Ejercicio6;

public class Biblioteca
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
    }

    private ArrayList listaLibros;
    private ArrayList listaMiembros;

    public Biblioteca(string nombre)
    {
        this.nombre = nombre;
        listaLibros = new ArrayList();
        listaMiembros = new ArrayList();
    }

    public void AgregarLibro(Libro libro)
    {
        listaLibros.Add(libro);
    }

    public void AgregarMiembro(Miembro miembro)
    {
        foreach (Miembro m in listaMiembros) 
        {
            if (m.Id == miembro.Id)
            {
                Console.WriteLine($"Ya hay un miembro con el Id {m.Id}");
                return;
            }
        }
        
        listaMiembros.Add(miembro);
    }

    public void MostrarLibrosDisponibles()
    {
        Console.WriteLine("Libros disponibles:");
        Console.WriteLine("===================");
        
        foreach (Libro libro in listaLibros)
        {
            if (libro.Disponible)
            {
                Console.WriteLine(libro);
            }
        }
    }
}