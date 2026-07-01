namespace BMW;

public class AirBag
{
    public int Size { get; set; }
    public int Amount { get; set; }
    public string Color { get; set; }

    public void Close()
    {
        Console.WriteLine("Remain closed while there isn't accident");
    }

    public void Open()
    {
        Console.WriteLine("Open when the car is involved in accident");
    }
}