namespace BMW;

public class HeadLamp
{
    public string HeadlightTypes { get; set; } // TODO: Replace string to HeadlightTypes enum
    public int Size { get; set; }
    public double Brightness { get; set; }

    public void TurnOn()
    {
        Console.WriteLine("Head light turn on when the car starts");
    }

    public void TurnOff()
    {
        Console.WriteLine("Head light Turn off when the car off");
    }
}