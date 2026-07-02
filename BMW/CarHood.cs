namespace BMW;

public class CarHood
{
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Width { get; set; }

    public void Open()
    {
        Console.WriteLine("Open the hood");
    }

    public void Close()
    {
        Console.WriteLine("Close the hood");
    }
}