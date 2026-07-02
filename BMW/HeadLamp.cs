namespace BMW;

public class HeadLamp
{
    public string HeadLampType { get; set; } // TODO: Fix it. You need to replace string to enum.
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