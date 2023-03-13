namespace LB5;

public class FlightLessBird : Bird
{
    public int MaxSpeed { get; }
    public FlightLessBird(int age, int maxSpeed) : base(age)
    {
        MaxSpeed = maxSpeed;
    }
        public virtual void Run()
        {
            Console.WriteLine("Максимальна швидкість бігу: " + MaxSpeed);
        }
}