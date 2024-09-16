namespace RepartidoClasesObj_PII.Ejercicio6;

public class Program
{
    public static void Main(string[] args)
    {
        Biblioteca b = new Biblioteca("Biblioteca Fantasía y Aventura");
        
        Libro l1 = new Libro("El señor de los anillos", "Tolkien");
        Libro l2 = new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling");
        Libro l3 = new Libro("La guerra de las galaxias", "George Lucas");
        b.AgregarLibro(l1);
        b.AgregarLibro(l2);
        b.AgregarLibro(l3);

        Miembro m1 = new Miembro("Juan", 1);
        Miembro m2 = new Miembro("Rodrigo", 2);
        Miembro m3 = new Miembro("Carla", 3);
        b.AgregarMiembro(m1);
        b.AgregarMiembro(m2);
        b.AgregarMiembro(m3);
        
        m1.PrestarLibro(l2); // OK
        m2.PrestarLibro(l2); // No lo presta, ya lo tiene m1 y no está disponible
        m1.DevolverLibro(l3); // No lo devuelve porque no lo tiene
        m1.DevolverLibro(l2); // OK
    }
}