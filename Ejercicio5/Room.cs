namespace RepartidoClasesObj_PII.Ejercicio5;

public class Room
{
    public int Number { get; set; }
    public int MaxGuests { get; set; }

    private GuestGroup currentGuests;
    private RoomBill bill;

    public Room(int number, int maxGuests, double pricePerDay)
    {
        Number = number;
        MaxGuests = maxGuests;
        bill = new RoomBill(pricePerDay);
    }

    public bool IsAvailable()
    {
        return currentGuests == null;
    }

    public GuestGroup GetCurrentGuests()
    {
        return currentGuests;
    }

    public void Occupy(GuestGroup guests)
    {
        currentGuests = guests;
        bill.TotalDays = guests.StayDuration;
    }

    public void Free()
    {
        currentGuests = null;
        bill.Clear();
    }

    public void RequestService(RoomService service)
    {
        bill.AddService(service);
    }

    public double GetBillTotal()
    {
        return bill.CalculateTotal();
    }
}