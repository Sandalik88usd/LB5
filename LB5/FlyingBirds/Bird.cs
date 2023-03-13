namespace LB5;

public abstract class Bird
{
    public int Age { get; }
    public virtual int MaxHeight { get; }

    public Bird(int age, int maxHeight)
    {
        Age = age;
        MaxHeight = maxHeight;
    }
    public Bird(int age)
    {
        Age = age;
    }

    public virtual void Fly()
    {
        Console.WriteLine("Максимальна висто польоту: " + MaxHeight);
    }
}