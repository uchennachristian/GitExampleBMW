namespace BMW;

public sealed class Door
{
    
    public int Width { get; set; }
    public int Height { get; set; }

    public void Open()
    {
        Console.WriteLine("open");
    }

    public void Close()
    {
        Console.WriteLine("close");
    }
    
}