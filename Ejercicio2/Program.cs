namespace RepartidoClasesObj_PII.Ejercicio2;

public class Program
{
    public static void Main(string[] args)
    {
        Ingredient i1 = new Ingredient("Vainilla", 0.5);
        Ingredient i2 = new Ingredient("Caramelo", 0.75);
        Ingredient i3 = new Ingredient("Copo de chantilly", 1.25);

        Smoothie s = new Smoothie("Batido de frutilla", 4.5);
        s.AddIngredient(i1);
        s.AddIngredient(i2);
        s.AddIngredient(i3);
        
        Console.WriteLine(s.GetFullName());
        Console.WriteLine($"Precio total: U$S {s.GetTotalPrice()}");
    }
}