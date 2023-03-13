namespace LB5;

public class Ostrich : FlightLessBird
{
    public Ostrich(int age) : base(age, 65)
    {
    }
    public override void Run()
    {
        Console.WriteLine("Максимальна швидкість бігу страуса: " + MaxSpeed + " км/год.");
    }
}