namespace RepartidoClasesObj_PII.Ejercicio5;

public class GuestGroup
{
    public int GroupSize { get; set; }
    public int StayDuration { get; set; }

    public GuestGroup(int groupSize, int stayDuration)
    {
        GroupSize = groupSize;
        StayDuration = stayDuration;
    }
}