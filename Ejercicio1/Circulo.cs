namespace RepartidoClasesObj_PII.Ejercicio1;

public class Circulo
{
    private double radio;

    public double Radio
    {
        get
        {
            return radio;
        }
    }

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double GetPerimeter()
    {
        return radio * 2 * Math.PI;
    }

    public double GetArea()
    {
        return radio * radio * Math.PI;
    }
}