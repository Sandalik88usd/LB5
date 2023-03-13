using System.Text;

namespace LB5;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Bird eagle = new Eagle(5);
        eagle.Fly();
        Bird parrot = new Parrot(3);
        parrot.Fly();
        FlightLessBird ostrich = new Ostrich(4);
        ostrich.Run();
        FlightLessBird penguin = new Penguin(1);
        penguin.Run();
        Console.WriteLine($"Вік папуги: {parrot.Age}\nВік орла: {eagle.Age}\nВік страуса: {ostrich.Age}" +
                          $"\nВік пінгвіна: {penguin.Age}\n");
        Console.ReadKey();
    }
}