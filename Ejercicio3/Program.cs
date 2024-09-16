namespace RepartidoClasesObj_PII.Ejercicio3;

public class Program
{
    public static void Main(string[] args)
    {
        Person abueloP = new Person("Artigas", "Abuelo");
        Person abuelaP = new Person("Ema", "Abuela");
        Person padre = new Person("Pablo", "Padre", abueloP, abuelaP);

        Person abueloM = new Person("Lelis", "Abuelo");
        Person abuelaM = new Person("Gladys", "Abuela");
        Person madre = new Person("Doris", "Madre", abueloM, abuelaM);
        
        Person yo = new Person("Marcelo", "Hijo", padre, madre);
        yo.ShowFamilyTree();
    }
}