namespace RepartidoClasesObj_PII.Ejercicio1;

public class Program
{
    public static void Main(string[] args)
    {
        Circulo c = new Circulo(5);
        Console.WriteLine($"Radio: {c.Radio}");
        Console.WriteLine($"Perímetro: {c.GetPerimeter()}");
        Console.WriteLine($"Área: {c.GetArea()}");
    }
}