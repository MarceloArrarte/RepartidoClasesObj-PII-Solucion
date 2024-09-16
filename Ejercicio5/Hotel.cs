using System.Collections;

namespace RepartidoClasesObj_PII.Ejercicio5;

public class Hotel
{
    public string Name { get; set; }
    private ArrayList rooms;
    private ArrayList availableServices;

    public Hotel(string name)
    {
        Name = name;
        rooms = new ArrayList();
        availableServices = new ArrayList();
    }

    public Room CheckinGuests(GuestGroup guests)
    {
        foreach (Room room in rooms)
        {
            if (room.IsAvailable() && guests.GroupSize <= room.MaxGuests)
            {
                room.Occupy(guests);
                return room;
            }
        }

        return null;
    }

    public bool CheckoutGuests(GuestGroup guests)
    {
        foreach (Room room in rooms)
        {
            if (room.GetCurrentGuests() == guests)
            {
                Console.WriteLine("Cuenta a pagar habitación {0}: ${1}", room.Number, room.GetBillTotal());
                room.Free();
                return true;
            }
        }

        return false;
    }

    public Room BuildRoom(int number, int maxGuests, double pricePerDay)
    {
        Room room = new Room(number, maxGuests, pricePerDay);
        rooms.Add(room);
        return room;
    }

    public RoomService AddRoomService(string name, double price)
    {
        RoomService service = new RoomService(name, price);
        availableServices.Add(service);
        return service;
    }
}