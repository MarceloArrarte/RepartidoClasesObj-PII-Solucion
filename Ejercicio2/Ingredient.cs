namespace RepartidoClasesObj_PII.Ejercicio2;

public class Ingredient
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
    }

    private double price;

    public double Price
    {
        get
        {
            return price;
        }
    }

    public Ingredient(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
}