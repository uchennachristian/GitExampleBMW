namespace BMW;

public class Engine
{
    public int Weight { get; set; }
    public string Name { get; set; }
    public int Height { get; set; }
    public int HorsePower { get; set; }

    public void Start()
    {
        Console.WriteLine("start");
    }

    public void TurnOff()
    {
        Console.WriteLine("turn off");
    }
    
}