namespace DesafioExtra;

// En realidad, esta clase podría implementarse como un caso específico de
// PromocionPorCantidad, con cantidad para aplicar la promo = 1.
// En otras palabras, "aplicar el x% de descuento cada 1 unidad" (o sea, en todas las unidades)
public class PromocionPorPorcentaje : IPromocion
{
    public Producto ProductoPromocionado { get; }
    private double porcentajeDescuento;

    public PromocionPorPorcentaje(Producto producto, double porcentajeDescuento)
    {
        ProductoPromocionado = producto;
        this.porcentajeDescuento = porcentajeDescuento;
    }

    public double CalcularPrecioPromocional(LineaVenta linea)
    {
        return linea.CalcularSubtotalLinea() * (1 - porcentajeDescuento);
    }
}