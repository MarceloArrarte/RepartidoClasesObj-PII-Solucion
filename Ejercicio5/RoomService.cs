namespace RepartidoClasesObj_PII.Ejercicio5;

public class RoomService
{
    public string Name { get; set; }
    public double Price { get; set; }

    public RoomService(string name, double price)
    {
        Name = name;
        Price = price;
    }
}