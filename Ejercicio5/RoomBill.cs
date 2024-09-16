using System.Collections;

namespace RepartidoClasesObj_PII.Ejercicio5;

public class RoomBill
{
    public double PricePerDay { get; set; }
    public int TotalDays { get; set; }
    private ArrayList orderedServices;

    public RoomBill(double pricePerDay)
    {
        PricePerDay = pricePerDay;
        orderedServices = new ArrayList();
    }

    public double CalculateTotal()
    {
        double servicesTotal = 0;
        foreach (RoomService service in orderedServices)
        {
            servicesTotal += service.Price;
        }

        return PricePerDay * TotalDays + servicesTotal;
    }

    public void AddService(RoomService service)
    {
        orderedServices.Add(service);
    }

    public void Clear()
    {
        orderedServices.Clear();
    }
}