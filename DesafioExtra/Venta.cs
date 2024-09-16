namespace DesafioExtra;

public class Venta
{
    private List<LineaVenta> lineas = new List<LineaVenta>();

    public IReadOnlyList<LineaVenta> Lineas
    {
        get { return lineas; }
    }
    

    private LineaVenta? obtenerLineaPorProducto(Producto producto)
    {
        foreach (LineaVenta linea in lineas)
        {
            if (linea.Producto == producto)
            {
                return linea;
            }
        }

        return null;
    }

    public void AgregarLinea(Producto producto, int cantidad, IPromocion? promocionAplicable)
    {
        LineaVenta? lineaExistente = obtenerLineaPorProducto(producto);

        if (lineaExistente != null)
        {
            lineaExistente.Cantidad += cantidad;
        }
        else
        {
            lineas.Add(new LineaVenta(producto, cantidad, promocionAplicable));
        }
    }

    public double CalcularPrecioFinal()
    {
        double total = 0;
        foreach (LineaVenta linea in lineas)
        {
            total += linea.CalcularTotalLinea();
        }

        return total;
    }
}