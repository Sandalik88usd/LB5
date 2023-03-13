namespace LB5;

public class Eagle : Bird
{
    public Eagle(int age) : base(age, 9)
    {
    }

    public override void Fly()
    {
        Console.WriteLine("Максимальна висота польоту орла: " + MaxHeight + " км.");
    }
}