namespace RepartidoClasesObj_PII.Ejercicio5;

public class Program
{
    public static void Main(string[] args)
    {
        Hotel hotel = new Hotel("BugFree Resort Punta del Este");
        Room r1 = hotel.BuildRoom(101, 2, 50);
        Room r2 = hotel.BuildRoom(102, 4, 75);
        RoomService s1 = hotel.AddRoomService("Masajes", 17);
        RoomService s2 = hotel.AddRoomService("Desayuno en suite", 12);
        
        GuestGroup guests = new GuestGroup(3, 5);
        Room chosenRoom = hotel.CheckinGuests(guests);
        chosenRoom.RequestService(s1);
        chosenRoom.RequestService(s2);
        hotel.CheckoutGuests(guests);
    }
}