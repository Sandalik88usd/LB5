namespace LB5;

public class Penguin : FlightLessBird
{
    public Penguin(int age) : base(age, 6)
    {
    }
    public override void Run()
    {
        Console.WriteLine("Максимальна швидкість бігу пінгвіна: " + MaxSpeed + " км/год.");
    }
}