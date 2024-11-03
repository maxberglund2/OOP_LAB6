namespace OOP_LAB6;

class Program
{
    static void Main(string[] args)
    {
        // Skapa olika djur
        Animal lion = new Lion();
        Animal eagle = new Eagle();
        Animal snake = new Snake();
        Animal python = new Python();
        Animal cobra = new Cobra();

        // Låt djuren göra sina ljud
        List<Animal> animals = new List<Animal> { lion, eagle, snake, python, cobra };

        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
            animal.Sleep();
            animal.Move();
            Console.WriteLine("----------------");
        }

    }
}