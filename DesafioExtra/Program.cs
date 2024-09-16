namespace DesafioExtra;

public class Program
{
    public static void Main(string[] args)
    {
        Tienda t = new Tienda();
        
        Producto camiseta = new Producto("Camiseta", 490, 350);
        Producto buzo = new Producto("Buzo", 1190, 720);
        Producto jean = new Producto("Jean", 1590, 880);

        t.AgregarPromocion(new PromocionPorCantidad(camiseta, 2, 0.50));
        t.AgregarPromocion(new PromocionPorPorcentaje(jean, 0.30));

        IPromocion? promoCamisetas = t.BuscarPromocionPorProducto(camiseta);
        IPromocion? promoBuzos = t.BuscarPromocionPorProducto(buzo);
        IPromocion? promoJeans = t.BuscarPromocionPorProducto(jean);

        Venta v1 = new Venta();
        v1.AgregarLinea(camiseta, 3, promoCamisetas);
        v1.AgregarLinea(buzo, 2, promoBuzos);
        v1.AgregarLinea(jean, 1, promoJeans);

        /*  Ejemplo del cálculo del precio total para esta venta:
         
            Producto	Precio	Cantidad	Promo	Total de línea
            Camiseta	490	    3	        -245	1225
            Buzo	    1190	2	        -0	    2380
            Jean	    1590	1	        -477	1113
			    
		    Total	4718
         */
        t.AgregarVenta(v1);

        Venta v2 = new Venta();
        v2.AgregarLinea(camiseta, 4, promoCamisetas);
        v2.AgregarLinea(jean, 2, promoJeans);
        
        t.AgregarVenta(v2);
        
        t.MostrarResumenVentas();
        Console.WriteLine();
        t.MostrarProductosMasVendidos();
        Console.WriteLine();
        
        /*
        Producto	Precio promedio venta	                            Costo	Ganancia
        Camiseta	PROMEDIO(490; 245; 490; 490; 245; 490; 245) = 385   350	    35
        Buzo	    PROMEDIO(1190;1190) = 1190	                        720	    470
        Jean	    PROMEDIO(1590*0,7; 1590 * 0,7; 1590 * 0,7) = 1113   880	    233
        */
        t.MostrarProductosConMayorYMenorGanancia();
    }
}