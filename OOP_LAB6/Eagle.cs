namespace OOP_LAB6;

public class Eagle : Animal
{
    public double Wingspan { get; set; }

    public Eagle(string name = "Eagle", int age = 3, double weight = 6.5, string habitat = "Mountains", bool isEndangered = true, double wingspan = 2.0)
        : base(name, age, weight, habitat, isEndangered)
    {
        Wingspan = wingspan;
    }

    public override void MakeSound() => Console.WriteLine($"{Name} screeches!");

    public void Fly() => Console.WriteLine($"{Name} is flying.");
}