namespace LB5;

public class Parrot : Bird
{
    public Parrot(int age) : base(age, 100)
    {
    }

    public override void Fly()
    {
        Console.WriteLine("Максимальна висота польоту папуги: " + MaxHeight + " м.");
    }
}