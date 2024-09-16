using System.Collections.Immutable;

namespace DesafioExtra;

public class Tienda
{
    private List<Venta> ventas = new List<Venta>();
    private List<IPromocion> promocionesVigentes = new List<IPromocion>();

    public void AgregarPromocion(IPromocion promocion)
    {
        promocionesVigentes.Add(promocion);
    }

    public IPromocion? BuscarPromocionPorProducto(Producto producto)
    {
        foreach (IPromocion promo in promocionesVigentes)
        {
            if (promo.ProductoPromocionado == producto)
            {
                return promo;
            }
        }

        return null;
    }

    public void AgregarVenta(Venta venta)
    {
        ventas.Add(venta);
    }

    public void MostrarResumenVentas()
    {
        for (int i = 0; i < ventas.Count; i++)
        {
            Venta venta = ventas[i];
            Console.WriteLine($"Venta {i + 1}: $ {venta.CalcularPrecioFinal()}");
        }
    }

    // Parte 3
    public void MostrarProductosMasVendidos()
    {
        // Primero, queremos saber cuántas unidades se han vendido de cada producto
        // en todas las ventas.
        Dictionary<Producto, int> cantidadesPorProducto = new Dictionary<Producto, int>();

        foreach (Venta venta in ventas)
        {
            foreach (LineaVenta linea in venta.Lineas)
            {
                // Si todavía no habíamos encontrado este producto, agregamos
                // la clave al diccionario
                if (cantidadesPorProducto.ContainsKey(linea.Producto))
                {
                    cantidadesPorProducto[linea.Producto] += linea.Cantidad;
                }
                // Si ya veníamos contando unidades de ese producto, sumamos
                // a esa cantidad.
                else
                {
                    cantidadesPorProducto.Add(linea.Producto, linea.Cantidad);
                }
            }
        }

        // Aquí, kvp hace referencia a key-value pair, que es cada par Producto-Cantidad
        // en nuestro diccionario. Key es el producto y Value es la cantidad.
        List<Producto> masVendidos = cantidadesPorProducto
            .OrderByDescending(kvp => kvp.Value)    // Ordenamos descendentemente por la cantidad.
            .Take(5)                                // Tomamos los primeros 5 productos.
            .Select(kvp => kvp.Key)                 // De cada par, tomamos la clave (el producto).
            .ToList();                              // Y transformamos el resultado en una lista
                                                    // para poder recorrerla como de costumbre.

        Console.WriteLine("Productos más vendidos:");
        foreach (Producto producto in masVendidos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, cantidad vendida: {cantidadesPorProducto[producto]}");
        }
    }

    
    // Parte 4
    public void MostrarProductosConMayorYMenorGanancia()
    {
        // Primero, debemos saber qué ganancia se obtuvo al vender cada unidad.
        // Esto lo podemos representar con una lista de doubles asociada a cada
        // Producto, donde cada elemento de la lista es la ganancia obtenida
        // por una unidad.
        Dictionary<Producto, List<double>> gananciasPorUnidadDeProducto = new Dictionary<Producto, List<double>>();
        
        foreach (Venta venta in ventas)
        {
            foreach (LineaVenta linea in venta.Lineas)
            {
                // Nuevamente, si es la primera vez que encontramos el Producto,
                // lo agregamos como clave del diccionario con una lista vacía como valor.
                if (!gananciasPorUnidadDeProducto.ContainsKey(linea.Producto))
                {
                    gananciasPorUnidadDeProducto[linea.Producto] = new List<double>();
                }
                
                // Calculamos el precio promedio al que se vendió cada unidad en esta venta,
                // aplicando promociones.
                // Por ejemplo, si se vendió una unidad a $100 y otra a $50, el precio promedio es $75.
                double precioVentaPromedioPorUnidad = linea.CalcularTotalLinea() / linea.Cantidad;
                
                // Le resto el costo del Producto para obtener la ganancia de esa unidad.
                double gananciaPorUnidad = precioVentaPromedioPorUnidad - linea.Producto.Costo;

                // Para cada unidad del Producto que haya vendido en esa venta,
                // agrego la ganancia promedio a la lista asociada al Producto.
                for (int i = 0; i < linea.Cantidad; i++)
                {
                    gananciasPorUnidadDeProducto[linea.Producto].Add(gananciaPorUnidad);
                }
            }
        }

        // Ahora que sabemos la ganancia que dio cada unidad, queremos saber la
        // ganancia promedio del producto, considerando todas las unidades vendidas.
        Dictionary<Producto, double> gananciasPromedioPorProducto = new Dictionary<Producto, double>();

        // Para cada Producto, su ganancia promedio por unidad es el promedio
        // de la lista de doubles que tiene asociada en el diccionario anterior.
        foreach (Producto producto in gananciasPorUnidadDeProducto.Keys)
        {
            double promedio = gananciasPorUnidadDeProducto[producto].Average();
            gananciasPromedioPorProducto[producto] = promedio;
        }
        
        
        // Key es el Producto, Value es la ganancia promedio por unidad de ese producto.
        List<Producto> productosConMayorGanancia = gananciasPromedioPorProducto
            .OrderByDescending(kvp => kvp.Value)        // Ordeno descendentemente por ganancia
            .Take(5)                                    // Tomo los primeros 5.
            .Select(kvp => kvp.Key)                     // Selecciono el Producto asociado.
            .ToList();                                  // Y paso a una lista para poder recorrerla.
        
        // Esto es análogo a lo anterior, pero ordeno ascendentemente para tener primero
        // los de menor ganancia.
        List<Producto> productosConMenorGanancia = gananciasPromedioPorProducto
            .OrderBy(kvp => kvp.Value)
            .Take(5)
            .Select(kvp => kvp.Key)
            .ToList();
        
        
        Console.WriteLine("Productos con mayor margen de ganancia:");
        foreach (Producto producto in productosConMayorGanancia)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, ganancia promedio por unidad vendida: {gananciasPromedioPorProducto[producto]}");
        }
        
        Console.WriteLine();
        Console.WriteLine("Productos con menor margen de ganancia:");
        foreach (Producto producto in productosConMenorGanancia)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, ganancia promedio por unidad vendida: {gananciasPromedioPorProducto[producto]}");
        }
    }
}