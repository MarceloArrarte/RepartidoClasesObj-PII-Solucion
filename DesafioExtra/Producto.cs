namespace DesafioExtra;

public class Producto
{
    public string Nombre { get; }
    public double PrecioVenta { get; }
    public double Costo { get; }

    public Producto(string nombre, double precio, double costo)
    {
        Nombre = nombre;
        PrecioVenta = precio;
        Costo = costo;
    }
}