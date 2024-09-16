namespace DesafioExtra;

public class LineaVenta
{
    public Producto Producto { get; }
    public int Cantidad { get; set; }
    public IPromocion? PromocionAplicable { get; }

    public LineaVenta(Producto producto, int cantidad, IPromocion promocionAplicable)
    {
        Producto = producto;
        Cantidad = cantidad;
        PromocionAplicable = promocionAplicable;
    }

    public double CalcularSubtotalLinea()
    {
        return Producto.PrecioVenta * Cantidad;
    }

    public double CalcularTotalLinea()
    {
        if (PromocionAplicable == null)
        {
            return CalcularSubtotalLinea();
        }
        else
        {
            return PromocionAplicable.CalcularPrecioPromocional(this);
        }
    }
}