namespace BMW;

public class WindshieldWiper
{
    public string CarWiper { get; set; } // TODO: What is it? 

    public void TurnOn()
    {
        Console.WriteLine("The wiper is going up and down cleaning the windshield");
    }

    public void TurnOff()
    {
        Console.WriteLine("The wiper has stopped working");
    }
}