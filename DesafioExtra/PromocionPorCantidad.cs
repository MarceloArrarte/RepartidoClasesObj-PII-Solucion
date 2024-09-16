namespace DesafioExtra;

public class PromocionPorCantidad : IPromocion
{
    public Producto ProductoPromocionado { get; }
    private int cantidadParaPromocion;
    private double porcentajeDescuento;

    public PromocionPorCantidad(Producto producto, int cantidadParaPromocion, double porcentajeDescuento)
    {
        ProductoPromocionado = producto;
        this.cantidadParaPromocion = cantidadParaPromocion;
        this.porcentajeDescuento = porcentajeDescuento;
    }

    public double CalcularPrecioPromocional(LineaVenta linea)
    {
        double descuentoPorVezAplicado = linea.Producto.PrecioVenta * porcentajeDescuento;
        int vecesAAplicar = linea.Cantidad / cantidadParaPromocion;
        double totalADescontar = descuentoPorVezAplicado * vecesAAplicar;
        
        return linea.CalcularSubtotalLinea() - totalADescontar;
    }
}