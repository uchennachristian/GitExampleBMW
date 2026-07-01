namespace BMW;

public class FuelTank
{
    public int TankCapacity { get; set; }

    public void EmptyTank()
    {
        Console.WriteLine("The tank in empty");
    }

    public void FillUpTank()
    {
        Console.WriteLine("The tank is full");
    }
    
}