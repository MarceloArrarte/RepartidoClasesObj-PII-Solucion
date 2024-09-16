namespace DesafioExtra;

public interface IPromocion
{
    public Producto ProductoPromocionado { get; }
    public double CalcularPrecioPromocional(LineaVenta linea);
}