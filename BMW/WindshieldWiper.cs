namespace BMW;

public class WindshieldWiper
{
    public int Lenght { get; set; } 
    public int Speed { get; set; }
    public void TurnOn()
    {
        Console.WriteLine("The wiper is going up and down cleaning the windshield");
    }

    public void TurnOff()
    {
        Console.WriteLine("The wiper has stopped working");
    }
}